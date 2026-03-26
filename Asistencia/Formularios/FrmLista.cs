using Asistencia.Clases;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Asistencia.Formularios
{
    public partial class FrmLista : Form
    {
        Datos datos = new Datos();

        public FrmLista()
        {
            InitializeComponent();
        }

        private void FrmLista_Load(object sender, EventArgs e)
        {
            // Solo permite la fecha de hoy
            DTPpasedelista.Value = DateTime.Today;
            DTPpasedelista.MinDate = DateTime.Today;
            DTPpasedelista.MaxDate = DateTime.Today;

            DataSet ds = datos.ejecutar("SELECT IdMateria, CONCAT(Clave,' - ',Nombre) AS Descripcion FROM Materia");
            if (ds == null || ds.Tables.Count == 0) return;
            CBmaterias.DisplayMember = "Descripcion";
            CBmaterias.ValueMember = "IdMateria";
            CBmaterias.DataSource = ds.Tables[0];
        }

        private void CBmaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBmaterias.SelectedValue == null) return;

            int idMateria = Convert.ToInt32(CBmaterias.SelectedValue);

            DataSet ds = datos.ejecutar(
                $"SELECT i.IdInscripcion, a.Numcontrol, " +
                $"a.Nombre, a.ApPaterno, a.ApMaterno, " +
                $"'Ausente' AS Estado " +
                $"FROM Inscripcion i " +
                $"JOIN Alumno a ON i.Numcontrol = a.Numcontrol " +
                $"WHERE i.IdMateria = {idMateria}");

            if (ds == null || ds.Tables.Count == 0) return;

            DGVlista.DataSource = ds.Tables[0];
            DGVlista.Columns["IdInscripcion"].Visible = false;

            DataGridViewComboBoxColumn colEstado = new DataGridViewComboBoxColumn();
            colEstado.Name = "Estado";
            colEstado.HeaderText = "Estado";
            colEstado.Items.AddRange("Presente", "Ausente", "Tardanza");
            colEstado.DataPropertyName = "Estado";
            colEstado.Width = 120;

            DGVlista.Columns.Remove("Estado");
            DGVlista.Columns.Add(colEstado);

            ActualizarPorcentaje();
        }

        private void DGVlista_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            ActualizarPorcentaje();
        }

        private void DGVlista_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (DGVlista.IsCurrentCellDirty)
                DGVlista.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void ActualizarPorcentaje()
        {
            int total = DGVlista.Rows.Count;
            if (total == 0) return;

            int presentes = 0;
            int ausentes = 0;

            for (int i = 0; i < total; i++)
            {
                string estado = DGVlista.Rows[i].Cells["Estado"].Value?.ToString() ?? "Ausente";
                if (estado == "Presente") presentes++;
                else ausentes++;
            }

            double porcentaje = (presentes * 100.0) / total;
            LBLporcentaje.Text = $"Presentes: {presentes} | Ausentes: {ausentes} | Asistencia del día: {porcentaje:F1}%";
        }

        private void BTNguardarlista_Click(object sender, EventArgs e)
        {
            if (CBmaterias.SelectedValue == null)
            {
                MessageBox.Show("Selecciona una materia primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fecha = DTPpasedelista.Value.ToString("yyyy-MM-dd");

            for (int i = 0; i < DGVlista.Rows.Count; i++)
            {
                int idInscripcion = Convert.ToInt32(DGVlista.Rows[i].Cells["IdInscripcion"].Value);
                string estado = DGVlista.Rows[i].Cells["Estado"].Value?.ToString() ?? "Ausente";

                datos.ejecutarComando(
                    $"INSERT INTO Asistencia (IdInscripcion, Fecha, Estado) " +
                    $"VALUES ({idInscripcion}, '{fecha}', '{estado}') " +
                    $"ON DUPLICATE KEY UPDATE Estado = '{estado}'");
            }

            MessageBox.Show("Lista guardada correctamente!");
        }
    }
}