using Asistencia.Formularios;

namespace Asistencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlumnos alumnos = new FrmAlumnos();
            alumnos.ShowDialog();
        }

        private void maestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMaterias materias = new FrmMaterias();
            materias.ShowDialog();
        }

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInscripciones inscripciones = new FrmInscripciones();
            inscripciones.ShowDialog();
        }

        private void pasarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLista listaAsistencia = new FrmLista();
            listaAsistencia.ShowDialog();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHistorial historial = new FrmHistorial();
            historial.ShowDialog();
        }

        private void resumenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmResumen resumen = new FrmResumen();
            resumen.ShowDialog();
        }

        private void MSprincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
