namespace Asistencia.Formularios
{
    partial class FrmNuevoAlumno
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
            label2 = new Label();
            TBXclave = new TextBox();
            label3 = new Label();
            TBXnombre = new TextBox();
            label4 = new Label();
            TBXgrupo = new TextBox();
            label5 = new Label();
            TBXsemestre = new TextBox();
            BTNCancelar = new Button();
            BTNguardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(130, 9);
            label1.Name = "label1";
            label1.Size = new Size(264, 35);
            label1.TabIndex = 3;
            label1.Text = "NUEVO ALUMNO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(52, 83);
            label2.Name = "label2";
            label2.Size = new Size(78, 26);
            label2.TabIndex = 9;
            label2.Text = "Clave:";
            // 
            // TBXclave
            // 
            TBXclave.Location = new Point(161, 81);
            TBXclave.Name = "TBXclave";
            TBXclave.Size = new Size(311, 31);
            TBXclave.TabIndex = 8;
            TBXclave.TextChanged += TBXnumcontrol_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(52, 138);
            label3.Name = "label3";
            label3.Size = new Size(103, 26);
            label3.TabIndex = 11;
            label3.Text = "Nombre:";
            // 
            // TBXnombre
            // 
            TBXnombre.Location = new Point(161, 136);
            TBXnombre.Name = "TBXnombre";
            TBXnombre.Size = new Size(311, 31);
            TBXnombre.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(52, 193);
            label4.Name = "label4";
            label4.Size = new Size(87, 26);
            label4.TabIndex = 13;
            label4.Text = "Grupo:";
            label4.Click += label4_Click;
            // 
            // TBXgrupo
            // 
            TBXgrupo.Location = new Point(202, 191);
            TBXgrupo.Name = "TBXgrupo";
            TBXgrupo.Size = new Size(270, 31);
            TBXgrupo.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(52, 248);
            label5.Name = "label5";
            label5.Size = new Size(113, 26);
            label5.TabIndex = 15;
            label5.Text = "Semestre:";
            // 
            // TBXsemestre
            // 
            TBXsemestre.Location = new Point(210, 246);
            TBXsemestre.Name = "TBXsemestre";
            TBXsemestre.Size = new Size(262, 31);
            TBXsemestre.TabIndex = 14;
            // 
            // BTNCancelar
            // 
            BTNCancelar.BackColor = Color.Red;
            BTNCancelar.ForeColor = Color.Transparent;
            BTNCancelar.Location = new Point(272, 315);
            BTNCancelar.Name = "BTNCancelar";
            BTNCancelar.Size = new Size(112, 34);
            BTNCancelar.TabIndex = 19;
            BTNCancelar.Text = "Cancelar";
            BTNCancelar.UseVisualStyleBackColor = false;
            BTNCancelar.Click += BTNCancelar_Click;
            // 
            // BTNguardar
            // 
            BTNguardar.BackColor = Color.Lime;
            BTNguardar.ForeColor = Color.Transparent;
            BTNguardar.Location = new Point(119, 313);
            BTNguardar.Name = "BTNguardar";
            BTNguardar.Size = new Size(112, 34);
            BTNguardar.TabIndex = 18;
            BTNguardar.Text = "Guardar";
            BTNguardar.UseVisualStyleBackColor = false;
            BTNguardar.Click += BTNguardar_Click;
            // 
            // FrmNuevoAlumno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 46);
            ClientSize = new Size(532, 395);
            Controls.Add(BTNCancelar);
            Controls.Add(BTNguardar);
            Controls.Add(label5);
            Controls.Add(TBXsemestre);
            Controls.Add(label4);
            Controls.Add(TBXgrupo);
            Controls.Add(label3);
            Controls.Add(TBXnombre);
            Controls.Add(label2);
            Controls.Add(TBXclave);
            Controls.Add(label1);
            Name = "FrmNuevoAlumno";
            Text = "FrmNuevoAlumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TBXclave;
        private Label label3;
        private TextBox TBXnombre;
        private Label label4;
        private TextBox TBXgrupo;
        private Label label5;
        private TextBox TBXsemestre;
        private Button BTNCancelar;
        private Button BTNguardar;
    }
}