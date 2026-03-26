namespace Asistencia.Formularios
{
    partial class FrmInscripciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            DGVinscritos = new DataGridView();
            DGVdisponibles = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            BTNeliminar = new Button();
            BTNnuevo = new Button();
            CBinscripciones = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DGVinscritos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVdisponibles).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(53, 98);
            label2.Name = "label2";
            label2.Size = new Size(104, 26);
            label2.TabIndex = 16;
            label2.Text = "Materia:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(506, 23);
            label1.Name = "label1";
            label1.Size = new Size(257, 35);
            label1.TabIndex = 14;
            label1.Text = "INSCRIPCIONES";
            // 
            // DGVinscritos
            // 
            DGVinscritos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVinscritos.Location = new Point(53, 229);
            DGVinscritos.Name = "DGVinscritos";
            DGVinscritos.RowHeadersWidth = 62;
            DGVinscritos.Size = new Size(554, 277);
            DGVinscritos.TabIndex = 17;
            // 
            // DGVdisponibles
            // 
            DGVdisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVdisponibles.Location = new Point(653, 229);
            DGVdisponibles.Name = "DGVdisponibles";
            DGVdisponibles.RowHeadersWidth = 62;
            DGVdisponibles.Size = new Size(554, 277);
            DGVdisponibles.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(229, 181);
            label3.Name = "label3";
            label3.Size = new Size(203, 26);
            label3.TabIndex = 19;
            label3.Text = "Alumnos inscritos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(811, 181);
            label4.Name = "label4";
            label4.Size = new Size(230, 26);
            label4.TabIndex = 20;
            label4.Text = "Alumnos disponibles:";
            // 
            // BTNeliminar
            // 
            BTNeliminar.BackColor = Color.Red;
            BTNeliminar.ForeColor = Color.Black;
            BTNeliminar.Location = new Point(206, 543);
            BTNeliminar.Name = "BTNeliminar";
            BTNeliminar.Size = new Size(112, 34);
            BTNeliminar.TabIndex = 22;
            BTNeliminar.Text = "Quitar";
            BTNeliminar.UseVisualStyleBackColor = false;
            BTNeliminar.Click += BTNeliminar_Click;
            // 
            // BTNnuevo
            // 
            BTNnuevo.BackColor = Color.Lime;
            BTNnuevo.ForeColor = Color.Black;
            BTNnuevo.Location = new Point(53, 541);
            BTNnuevo.Name = "BTNnuevo";
            BTNnuevo.Size = new Size(112, 34);
            BTNnuevo.TabIndex = 21;
            BTNnuevo.Text = "Inscribir";
            BTNnuevo.UseVisualStyleBackColor = false;
            BTNnuevo.Click += BTNnuevo_Click;
            // 
            // CBinscripciones
            // 
            CBinscripciones.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CBinscripciones.FormattingEnabled = true;
            CBinscripciones.Location = new Point(163, 95);
            CBinscripciones.Name = "CBinscripciones";
            CBinscripciones.Size = new Size(366, 35);
            CBinscripciones.TabIndex = 23;
            CBinscripciones.SelectedIndexChanged += CBinscripciones_SelectedIndexChanged;
            // 
            // FrmInscripciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 36);
            ClientSize = new Size(1257, 609);
            Controls.Add(CBinscripciones);
            Controls.Add(BTNeliminar);
            Controls.Add(BTNnuevo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(DGVdisponibles);
            Controls.Add(DGVinscritos);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmInscripciones";
            Text = "FrmInscripciones";
            Load += FrmInscripciones_Load;
            ((System.ComponentModel.ISupportInitialize)DGVinscritos).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVdisponibles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DataGridView DGVinscritos;
        private DataGridView DGVdisponibles;
        private Label label3;
        private Label label4;
        private Button BTNeliminar;
        private Button BTNnuevo;
        private ComboBox CBinscripciones;
    }
}