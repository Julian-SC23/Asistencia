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
    public partial class FrmMaterias : Form
    {
        Datos datos = new Datos();
        public FrmMaterias()
        {
            InitializeComponent();
        }

        private void FrmMaterias_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            string filtro = TBXbuscmaterias.Text.Replace("'", "''");
            DataSet ds = datos.ejecutar(
                $"SELECT IdMateria, Clave, Nombre, Grupo, Semestre " +
                $"FROM Materia " +
                $"WHERE Clave LIKE '%{filtro}%' " +
                $"OR Nombre LIKE '%{filtro}%' " +
                $"OR Grupo LIKE '%{filtro}%'");

            DGVmaterias.DataSource = ds.Tables[0];
        }

        private void BTNeliminar_Click(object sender, EventArgs e)
        {
            if (DGVmaterias.CurrentRow == null) return;

            string id = DGVmaterias.CurrentRow.Cells["IdMateria"].Value.ToString();
            string nombre = DGVmaterias.CurrentRow.Cells["Nombre"].Value.ToString();

            DialogResult respuesta = MessageBox.Show(
                $"¿Seguro que quieres eliminar la materia {nombre}?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                datos.ejecutarComando($"DELETE FROM Materia WHERE IdMateria = {id}");
                Buscar();
            }
        }

        private void BTNnuevo_Click(object sender, EventArgs e)
        {
            FrmNuevaMateria frm = new FrmNuevaMateria();
            frm.ShowDialog();
            Buscar();
        }

        private void TBXbuscmaterias_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
