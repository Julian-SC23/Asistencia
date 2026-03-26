using Asistencia.Clases;
using System;
using System.Windows.Forms;

namespace Asistencia.Formularios
{
    public partial class FrmNuevaMateria : Form
    {
        Datos datos = new Datos();

        public FrmNuevaMateria()
        {
            InitializeComponent();
        }

        private void BTNguardar_Click(object sender, EventArgs e)
        {
            string clave = TBXclave.Text.Trim();
            string nombre = TBXnombre.Text.Trim();
            string grupo = TBXgrupo.Text.Trim();
            string semestre = TBXsemestre.Text.Trim();

            if (clave == "" || nombre == "" || grupo == "" || semestre == "")
            {
                MessageBox.Show("Todos los campos son obligatorios!",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ok = datos.ejecutarComando(
                $"INSERT INTO Materia (Clave, Nombre, Grupo, Semestre) " +
                $"VALUES ('{clave}', '{nombre}', '{grupo}', {semestre})");

            if (ok)
            {
                MessageBox.Show("Materia guardada correctamente!");
                Close();
            }
            else
            {
                MessageBox.Show("Error, verifica que la clave no esté duplicada.");
            }
        }

        private void BTNcancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmNuevaMateria_Load(object sender, EventArgs e)
        {

        }
    }
}