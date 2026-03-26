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
    public partial class FrmHistorial : Form
    {
        Datos datos = new Datos();
        public FrmHistorial()
        {
            InitializeComponent();
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            DataSet ds = datos.ejecutar("SELECT IdMateria, CONCAT(Clave,' - ',Nombre) AS Descripcion FROM Materia");
            CBhistorial.DisplayMember = "Descripcion";
            CBhistorial.ValueMember = "IdMateria";
            CBhistorial.DataSource = ds.Tables[0];
        }

        private void BTNconsultarhistorial_Click(object sender, EventArgs e)
        {
            string fecha = DTPhistorial.Value.ToString("yyyy-MM-dd");
            int idMateria = Convert.ToInt32(CBhistorial.SelectedValue);
            string buscar = TBXhistorial.Text.Replace("'", "''");

            DataSet ds = datos.ejecutar(
                $"SELECT a.Numcontrol, a.Nombre, a.ApPaterno, a.ApMaterno, asi.Estado " +
                $"FROM Asistencia asi " +
                $"JOIN Inscripcion i ON asi.IdInscripcion = i.IdInscripcion " +
                $"JOIN Alumno a ON i.Numcontrol = a.Numcontrol " +
                $"WHERE i.IdMateria = {idMateria} AND asi.Fecha = '{fecha}' " +
                $"AND (a.Numcontrol LIKE '%{buscar}%' OR a.Nombre LIKE '%{buscar}%' " +
                $"OR a.ApPaterno LIKE '%{buscar}%')");

            DGVhistorial.DataSource = ds.Tables[0];
        }

        private void TBXhistorial_TextChanged(object sender, EventArgs e)
        {
            BTNconsultarhistorial_Click(sender, e);
        }
    }
}
