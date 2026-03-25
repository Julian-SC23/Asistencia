using Asistencia.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Asistencia.Formularios
{
    public partial class FrmAlumnos : Form
    {
        Datos datos = new Datos();
        public FrmAlumnos()
        {
            InitializeComponent();
        }



        private void FrmAlumnos_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            string filtro = TBXbuscarmateria.Text.Replace("'", "''");
            DataSet ds = datos.ejecutar(
                $"SELECT Numcontrol, Nombre, ApPaterno, ApMaterno, Email " +
                $"FROM Alumno " +
                $"WHERE Numcontrol LIKE '%{filtro}%' " +
                $"OR Nombre LIKE '%{filtro}%' " +
                $"OR ApPaterno LIKE '%{filtro}%' " +
                $"OR ApMaterno LIKE '%{filtro}%'");

            DGValumnos.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void BTNeliminar_Click(object sender, EventArgs e)
        {
            if (DGValumnos.CurrentRow == null) return;

            string nc = DGValumnos.CurrentRow.Cells["Numcontrol"].Value.ToString();

            DialogResult respuesta = MessageBox.Show(
                $"¿Seguro que quieres eliminar al alumno {nc}?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                datos.ejecutarComando($"DELETE FROM Alumno WHERE Numcontrol = '{nc}'");
                Buscar();
            }
        }

        private void BTNnuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoAlumno frm = new FrmNuevoAlumno();
            frm.ShowDialog();
            Buscar();
        }
    }
}
