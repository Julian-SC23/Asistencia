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
    public partial class FrmNuevoAlumno : Form
    {
        Datos datos = new Datos();
        public FrmNuevoAlumno()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BTNguardar_Click(object sender, EventArgs e)
        {
            string nc = TBXclave.Text.Trim();
            string nom = TBXnombre.Text.Trim();
            string app = TBXgrupo.Text.Trim();
            string apm = TBXsemestre.Text.Trim();
            string mail = TBXemail.Text.Trim();

            if (nc == "" || nom == "" || app == "")
            {
                MessageBox.Show("Num. de control, nombre y apellido paterno son obligatorios!",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ok = datos.ejecutarComando(
                $"INSERT INTO Alumno (Numcontrol, Nombre, ApPaterno, ApMaterno, Email) " +
                $"VALUES ('{nc}', '{nom}', '{app}', '{apm}', '{mail}')");

            if (ok)
            {
                MessageBox.Show("Alumno guardado correctamente!");
                Close();
            }
            else
            {
                MessageBox.Show("Error, verifica que el número de control no esté duplicado.");
            }
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBXnumcontrol_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
