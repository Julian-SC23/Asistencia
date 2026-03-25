namespace Asistencia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MSprincipal = new MenuStrip();
            catalogosToolStripMenuItem = new ToolStripMenuItem();
            alumnosToolStripMenuItem = new ToolStripMenuItem();
            maestrosToolStripMenuItem = new ToolStripMenuItem();
            inscripcionesToolStripMenuItem = new ToolStripMenuItem();
            asistenciaToolStripMenuItem = new ToolStripMenuItem();
            pasarListaToolStripMenuItem = new ToolStripMenuItem();
            historialToolStripMenuItem = new ToolStripMenuItem();
            resumenToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            MSprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // MSprincipal
            // 
            MSprincipal.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MSprincipal.ImageScalingSize = new Size(24, 24);
            MSprincipal.Items.AddRange(new ToolStripItem[] { catalogosToolStripMenuItem, asistenciaToolStripMenuItem });
            MSprincipal.Location = new Point(0, 0);
            MSprincipal.Name = "MSprincipal";
            MSprincipal.RenderMode = ToolStripRenderMode.Professional;
            MSprincipal.Size = new Size(840, 28);
            MSprincipal.TabIndex = 0;
            MSprincipal.Text = "menuStrip1";
            MSprincipal.ItemClicked += MSprincipal_ItemClicked;
            // 
            // catalogosToolStripMenuItem
            // 
            catalogosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alumnosToolStripMenuItem, maestrosToolStripMenuItem, inscripcionesToolStripMenuItem });
            catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            catalogosToolStripMenuItem.Size = new Size(95, 24);
            catalogosToolStripMenuItem.Text = "Catalogos";
            // 
            // alumnosToolStripMenuItem
            // 
            alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            alumnosToolStripMenuItem.Size = new Size(202, 34);
            alumnosToolStripMenuItem.Text = "Alumnos";
            alumnosToolStripMenuItem.Click += alumnosToolStripMenuItem_Click;
            // 
            // maestrosToolStripMenuItem
            // 
            maestrosToolStripMenuItem.Name = "maestrosToolStripMenuItem";
            maestrosToolStripMenuItem.Size = new Size(202, 34);
            maestrosToolStripMenuItem.Text = "Materias";
            maestrosToolStripMenuItem.Click += maestrosToolStripMenuItem_Click;
            // 
            // inscripcionesToolStripMenuItem
            // 
            inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            inscripcionesToolStripMenuItem.Size = new Size(202, 34);
            inscripcionesToolStripMenuItem.Text = "Inscripciones";
            inscripcionesToolStripMenuItem.Click += inscripcionesToolStripMenuItem_Click;
            // 
            // asistenciaToolStripMenuItem
            // 
            asistenciaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pasarListaToolStripMenuItem, historialToolStripMenuItem, resumenToolStripMenuItem });
            asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            asistenciaToolStripMenuItem.Size = new Size(97, 24);
            asistenciaToolStripMenuItem.Text = "Asistencia";
            // 
            // pasarListaToolStripMenuItem
            // 
            pasarListaToolStripMenuItem.Name = "pasarListaToolStripMenuItem";
            pasarListaToolStripMenuItem.Size = new Size(181, 34);
            pasarListaToolStripMenuItem.Text = "Pasar lista";
            pasarListaToolStripMenuItem.Click += pasarListaToolStripMenuItem_Click;
            // 
            // historialToolStripMenuItem
            // 
            historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            historialToolStripMenuItem.Size = new Size(181, 34);
            historialToolStripMenuItem.Text = "historial";
            historialToolStripMenuItem.Click += historialToolStripMenuItem_Click;
            // 
            // resumenToolStripMenuItem
            // 
            resumenToolStripMenuItem.Name = "resumenToolStripMenuItem";
            resumenToolStripMenuItem.Size = new Size(181, 34);
            resumenToolStripMenuItem.Text = "Resumen";
            resumenToolStripMenuItem.Click += resumenToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(237, 114);
            label1.Name = "label1";
            label1.Size = new Size(365, 55);
            label1.TabIndex = 1;
            label1.Text = "CheckIn Escolar";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(208, 205);
            label2.Name = "label2";
            label2.Size = new Size(423, 34);
            label2.TabIndex = 2;
            label2.Text = "Seleccione una opcion del menu :)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 46);
            ClientSize = new Size(840, 375);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MSprincipal);
            MainMenuStrip = MSprincipal;
            Name = "Form1";
            Text = "CheckIn Escolar";
            Load += Form1_Load;
            MSprincipal.ResumeLayout(false);
            MSprincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MSprincipal;
        private ToolStripMenuItem catalogosToolStripMenuItem;
        private ToolStripMenuItem alumnosToolStripMenuItem;
        private ToolStripMenuItem maestrosToolStripMenuItem;
        private ToolStripMenuItem asistenciaToolStripMenuItem;
        private ToolStripMenuItem pasarListaToolStripMenuItem;
        private ToolStripMenuItem historialToolStripMenuItem;
        private ToolStripMenuItem resumenToolStripMenuItem;
        private ToolStripMenuItem inscripcionesToolStripMenuItem;
        private Label label1;
        private Label label2;
    }
}
