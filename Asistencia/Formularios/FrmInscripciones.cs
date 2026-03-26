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
    public partial class FrmInscripciones : Form
    {
        Datos datos = new Datos();

        public FrmInscripciones()
        {
            InitializeComponent();
        }

        private void FrmInscripciones_Load(object sender, EventArgs e)
        {
            DataSet ds = datos.ejecutar("SELECT IdMateria, CONCAT(Clave,' - ',Nombre) AS Descripcion FROM Materia");
            CBinscripciones.DisplayMember = "Descripcion";
            CBinscripciones.ValueMember = "IdMateria";
            CBinscripciones.DataSource = ds.Tables[0];
            CBinscripciones.SelectedIndex = -1;
        }

        private void CBinscripciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBinscripciones.SelectedValue == null) return;
            CargarInscritos();
            CargarDisponibles();
        }

        private void CargarInscritos()
        {
            int idMateria = Convert.ToInt32(CBinscripciones.SelectedValue);
            DataSet ds = datos.ejecutar(
                $"SELECT a.Numcontrol, a.Nombre, a.ApPaterno " +
                $"FROM Inscripcion i JOIN Alumno a ON i.Numcontrol = a.Numcontrol " +
                $"WHERE i.IdMateria = {idMateria}");
            DGVinscritos.DataSource = ds.Tables[0];
        }

        private void CargarDisponibles()
        {
            int idMateria = Convert.ToInt32(CBinscripciones.SelectedValue);
            DataSet ds = datos.ejecutar(
                $"SELECT Numcontrol, Nombre, ApPaterno FROM Alumno " +
                $"WHERE Numcontrol NOT IN " +
                $"(SELECT Numcontrol FROM Inscripcion WHERE IdMateria = {idMateria})");
            DGVdisponibles.DataSource = ds.Tables[0];
        }

        private void BTNnuevo_Click(object sender, EventArgs e)
        {
            if (DGVdisponibles.CurrentRow == null) return;
            int idMateria = Convert.ToInt32(CBinscripciones.SelectedValue);
            string nc = DGVdisponibles.CurrentRow.Cells["Numcontrol"].Value.ToString();
            datos.ejecutarComando($"INSERT INTO Inscripcion (Numcontrol, IdMateria) VALUES ('{nc}', {idMateria})");
            CargarInscritos();
            CargarDisponibles();
        }

        private void BTNeliminar_Click(object sender, EventArgs e)
        {
            if (DGVinscritos.CurrentRow == null) return;
            int idMateria = Convert.ToInt32(CBinscripciones.SelectedValue);
            string nc = DGVinscritos.CurrentRow.Cells["Numcontrol"].Value.ToString();

            DialogResult respuesta = MessageBox.Show(
                $"¿Quitar a {nc} de esta materia?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                datos.ejecutarComando($"DELETE FROM Inscripcion WHERE Numcontrol = '{nc}' AND IdMateria = {idMateria}");
                CargarInscritos();
                CargarDisponibles();
            }
        }
    }
}
