using Asistencia.Clases;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Asistencia.Formularios
{
    public partial class FrmResumen : Form
    {
        Datos datos = new Datos();

        public FrmResumen()
        {
            InitializeComponent();
        }

        private void FrmResumen_Load(object sender, EventArgs e)
        {
            TBXmin.Text = "80";

            DataSet ds = datos.ejecutar(
                "SELECT 0 AS IdMateria, '— Todas —' AS Descripcion " +
                "UNION " +
                "SELECT IdMateria, CONCAT(Clave,' - ',Nombre) FROM Materia ORDER BY 1");
            if (ds == null || ds.Tables.Count == 0) return;
            CBhistorial.DisplayMember = "Descripcion";
            CBhistorial.ValueMember = "IdMateria";
            CBhistorial.DataSource = ds.Tables[0];
        }

        private void BTNconsultar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(TBXmin.Text, out double minimo))
            {
                MessageBox.Show("Escribe un porcentaje válido.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string filMateria = CBhistorial.SelectedValue?.ToString() == "0"
                ? ""
                : $"AND i.IdMateria = {CBhistorial.SelectedValue}";

            DataSet ds = datos.ejecutar(
                $"SELECT a.Numcontrol, a.Nombre, a.ApPaterno, a.ApMaterno, " +
                $"m.Nombre AS Materia, " +
                $"COUNT(*) AS TotalClases, " +
                $"SUM(ast.Estado = 'Presente') AS Presentes, " +
                $"SUM(ast.Estado = 'Ausente') AS Ausentes, " +
                $"SUM(ast.Estado = 'Tardanza') AS Tardanzas, " +
                $"ROUND(SUM(ast.Estado = 'Presente') * 100.0 / COUNT(*), 1) AS Porcentaje " +
                $"FROM Asistencia ast " +
                $"JOIN Inscripcion i ON ast.IdInscripcion = i.IdInscripcion " +
                $"JOIN Alumno a ON i.Numcontrol = a.Numcontrol " +
                $"JOIN Materia m ON i.IdMateria = m.IdMateria " +
                $"WHERE 1=1 {filMateria} " +
                $"GROUP BY a.Numcontrol, m.IdMateria " +
                $"ORDER BY a.ApPaterno");

            if (ds == null || ds.Tables.Count == 0) return;
            DGVresumen.DataSource = ds.Tables[0];
            ColorizarFilas(minimo);
        }

        private void ColorizarFilas(double minimo)
        {
            for (int i = 0; i < DGVresumen.Rows.Count; i++)
            {
                double pct = Convert.ToDouble(DGVresumen.Rows[i].Cells["Porcentaje"].Value);

                Color color;
                if (pct >= minimo)
                    color = Color.FromArgb(40, 90, 40);        // verde
                else if (pct >= minimo - 10)
                    color = Color.FromArgb(120, 90, 0);        // amarillo
                else
                    color = Color.FromArgb(120, 30, 30);       // rojo

                DGVresumen.Rows[i].DefaultCellStyle.BackColor = color;
                DGVresumen.Rows[i].DefaultCellStyle.ForeColor = Color.White;
            }
        }
    }
}