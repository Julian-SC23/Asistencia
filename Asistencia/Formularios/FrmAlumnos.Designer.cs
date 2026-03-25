namespace Asistencia.Formularios
{
    partial class FrmAlumnos
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
            TBXbuscarmateria = new TextBox();
            BTNnuevo = new Button();
            BTNeliminar = new Button();
            DGValumnos = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGValumnos).BeginInit();
            SuspendLayout();
            // 
            // TBXbuscarmateria
            // 
            TBXbuscarmateria.Location = new Point(164, 80);
            TBXbuscarmateria.Name = "TBXbuscarmateria";
            TBXbuscarmateria.Size = new Size(466, 31);
            TBXbuscarmateria.TabIndex = 3;
            // 
            // BTNnuevo
            // 
            BTNnuevo.BackColor = Color.Lime;
            BTNnuevo.ForeColor = Color.Black;
            BTNnuevo.Location = new Point(671, 78);
            BTNnuevo.Name = "BTNnuevo";
            BTNnuevo.Size = new Size(112, 34);
            BTNnuevo.TabIndex = 4;
            BTNnuevo.Text = "Nuevo";
            BTNnuevo.UseVisualStyleBackColor = false;
            BTNnuevo.Click += BTNnuevo_Click;
            // 
            // BTNeliminar
            // 
            BTNeliminar.BackColor = Color.Red;
            BTNeliminar.ForeColor = Color.Black;
            BTNeliminar.Location = new Point(824, 80);
            BTNeliminar.Name = "BTNeliminar";
            BTNeliminar.Size = new Size(112, 34);
            BTNeliminar.TabIndex = 5;
            BTNeliminar.Text = "Eliminar";
            BTNeliminar.UseVisualStyleBackColor = false;
            BTNeliminar.Click += BTNeliminar_Click;
            // 
            // DGValumnos
            // 
            DGValumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGValumnos.Location = new Point(60, 150);
            DGValumnos.Name = "DGValumnos";
            DGValumnos.RowHeadersWidth = 62;
            DGValumnos.Size = new Size(876, 225);
            DGValumnos.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(60, 82);
            label2.Name = "label2";
            label2.Size = new Size(98, 26);
            label2.TabIndex = 7;
            label2.Text = "Buscar: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(423, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 35);
            label1.TabIndex = 2;
            label1.Text = "ALUMNOS";
            // 
            // FrmAlumnos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 46);
            ClientSize = new Size(1000, 441);
            Controls.Add(label2);
            Controls.Add(DGValumnos);
            Controls.Add(BTNeliminar);
            Controls.Add(BTNnuevo);
            Controls.Add(TBXbuscarmateria);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "FrmAlumnos";
            Text = "FrmAlumnos";
            Load += FrmAlumnos_Load;
            ((System.ComponentModel.ISupportInitialize)DGValumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TBXbuscarmateria;
        private Button BTNnuevo;
        private Button BTNeliminar;
        private DataGridView DGValumnos;
        private Label label2;
        private Label label1;
    }
}