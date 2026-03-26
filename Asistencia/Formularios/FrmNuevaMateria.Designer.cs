namespace Asistencia.Formularios
{
    partial class FrmNuevaMateria
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
            label1 = new Label();
            BTNcancelar = new Button();
            BTNguardar = new Button();
            label7 = new Label();
            TBXsemestre = new TextBox();
            label8 = new Label();
            TBXgrupo = new TextBox();
            label9 = new Label();
            TBXnombre = new TextBox();
            label10 = new Label();
            TBXclave = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(133, 26);
            label1.Name = "label1";
            label1.Size = new Size(265, 35);
            label1.TabIndex = 20;
            label1.Text = "NUEVA MATERIA";
            // 
            // BTNcancelar
            // 
            BTNcancelar.BackColor = Color.Red;
            BTNcancelar.ForeColor = Color.Transparent;
            BTNcancelar.Location = new Point(271, 327);
            BTNcancelar.Name = "BTNcancelar";
            BTNcancelar.Size = new Size(112, 34);
            BTNcancelar.TabIndex = 42;
            BTNcancelar.Text = "Cancelar";
            BTNcancelar.UseVisualStyleBackColor = false;
            BTNcancelar.Click += BTNcancelar_Click;
            // 
            // BTNguardar
            // 
            BTNguardar.BackColor = Color.Lime;
            BTNguardar.ForeColor = Color.Transparent;
            BTNguardar.Location = new Point(118, 325);
            BTNguardar.Name = "BTNguardar";
            BTNguardar.Size = new Size(112, 34);
            BTNguardar.TabIndex = 41;
            BTNguardar.Text = "Guardar";
            BTNguardar.UseVisualStyleBackColor = false;
            BTNguardar.Click += BTNguardar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(51, 260);
            label7.Name = "label7";
            label7.Size = new Size(113, 26);
            label7.TabIndex = 40;
            label7.Text = "Semestre:";
            // 
            // TBXsemestre
            // 
            TBXsemestre.Location = new Point(209, 258);
            TBXsemestre.Name = "TBXsemestre";
            TBXsemestre.Size = new Size(262, 31);
            TBXsemestre.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(51, 205);
            label8.Name = "label8";
            label8.Size = new Size(87, 26);
            label8.TabIndex = 38;
            label8.Text = "Grupo:";
            // 
            // TBXgrupo
            // 
            TBXgrupo.Location = new Point(201, 203);
            TBXgrupo.Name = "TBXgrupo";
            TBXgrupo.Size = new Size(270, 31);
            TBXgrupo.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(51, 150);
            label9.Name = "label9";
            label9.Size = new Size(103, 26);
            label9.TabIndex = 36;
            label9.Text = "Nombre:";
            // 
            // TBXnombre
            // 
            TBXnombre.Location = new Point(160, 148);
            TBXnombre.Name = "TBXnombre";
            TBXnombre.Size = new Size(311, 31);
            TBXnombre.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(51, 95);
            label10.Name = "label10";
            label10.Size = new Size(78, 26);
            label10.TabIndex = 34;
            label10.Text = "Clave:";
            // 
            // TBXclave
            // 
            TBXclave.Location = new Point(160, 93);
            TBXclave.Name = "TBXclave";
            TBXclave.Size = new Size(311, 31);
            TBXclave.TabIndex = 33;
            // 
            // FrmNuevaMateria
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 36);
            ClientSize = new Size(533, 393);
            Controls.Add(BTNcancelar);
            Controls.Add(BTNguardar);
            Controls.Add(label7);
            Controls.Add(TBXsemestre);
            Controls.Add(label8);
            Controls.Add(TBXgrupo);
            Controls.Add(label9);
            Controls.Add(TBXnombre);
            Controls.Add(label10);
            Controls.Add(TBXclave);
            Controls.Add(label1);
            Name = "FrmNuevaMateria";
            Text = "FrmNuevaMateria";
            Load += FrmNuevaMateria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button BTNcancelar;
        private Button BTNguardar;
        private Label label7;
        private TextBox TBXsemestre;
        private Label label8;
        private TextBox TBXgrupo;
        private Label label9;
        private TextBox TBXnombre;
        private Label label10;
        private TextBox TBXclave;
    }
}