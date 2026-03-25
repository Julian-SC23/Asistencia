using Asistencia.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Asistencia.Formularios
{
    public partial class FrmLista : Form
    {
        public FrmLista()
        {
            InitializeComponent();


        }
        Datos datos = new Datos();

        private void FrmLista_Load(object sender, EventArgs e)
        {
            DataSet ds = datos.ejecutar("SELECT IdMateria, CONCAT(Clave,' - ',Nombre) AS Desc FROM Materia");
            CBmaterias.DisplayMember = "Desc";
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
        }

        private void BTNguardarlista_Click(object sender, EventArgs e)
        {
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
