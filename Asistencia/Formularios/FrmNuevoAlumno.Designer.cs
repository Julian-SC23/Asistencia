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
            BTNCancelar = new Button();
            BTNguardar = new Button();
            label6 = new Label();
            TBXemail = new TextBox();
            label5 = new Label();
            TBXmaterno = new TextBox();
            label4 = new Label();
            TBXpaterno = new TextBox();
            label3 = new Label();
            TBXnombre = new TextBox();
            label2 = new Label();
            TBXnumcontrol = new TextBox();
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
            // BTNCancelar
            // 
            BTNCancelar.BackColor = Color.Red;
            BTNCancelar.ForeColor = Color.Black;
            BTNCancelar.Location = new Point(280, 348);
            BTNCancelar.Name = "BTNCancelar";
            BTNCancelar.Size = new Size(112, 34);
            BTNCancelar.TabIndex = 44;
            BTNCancelar.Text = "Cancelar";
            BTNCancelar.UseVisualStyleBackColor = false;
            BTNCancelar.Click += BTNCancelar_Click_1;
            // 
            // BTNguardar
            // 
            BTNguardar.BackColor = Color.Lime;
            BTNguardar.ForeColor = Color.Black;
            BTNguardar.Location = new Point(127, 346);
            BTNguardar.Name = "BTNguardar";
            BTNguardar.Size = new Size(112, 34);
            BTNguardar.TabIndex = 43;
            BTNguardar.Text = "Guardar";
            BTNguardar.UseVisualStyleBackColor = false;
            BTNguardar.Click += BTNguardar_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(54, 291);
            label6.Name = "label6";
            label6.Size = new Size(81, 26);
            label6.TabIndex = 42;
            label6.Text = "Email:";
            // 
            // TBXemail
            // 
            TBXemail.Location = new Point(141, 286);
            TBXemail.Name = "TBXemail";
            TBXemail.Size = new Size(333, 31);
            TBXemail.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(54, 236);
            label5.Name = "label5";
            label5.Size = new Size(152, 26);
            label5.TabIndex = 40;
            label5.Text = "Ap. Materno:";
            // 
            // TBXmaterno
            // 
            TBXmaterno.Location = new Point(212, 234);
            TBXmaterno.Name = "TBXmaterno";
            TBXmaterno.Size = new Size(262, 31);
            TBXmaterno.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(54, 181);
            label4.Name = "label4";
            label4.Size = new Size(144, 26);
            label4.TabIndex = 38;
            label4.Text = "Ap. Paterno:";
            // 
            // TBXpaterno
            // 
            TBXpaterno.Location = new Point(204, 179);
            TBXpaterno.Name = "TBXpaterno";
            TBXpaterno.Size = new Size(270, 31);
            TBXpaterno.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(54, 126);
            label3.Name = "label3";
            label3.Size = new Size(103, 26);
            label3.TabIndex = 36;
            label3.Text = "Nombre:";
            // 
            // TBXnombre
            // 
            TBXnombre.Location = new Point(163, 124);
            TBXnombre.Name = "TBXnombre";
            TBXnombre.Size = new Size(311, 31);
            TBXnombre.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(54, 71);
            label2.Name = "label2";
            label2.Size = new Size(185, 26);
            label2.TabIndex = 34;
            label2.Text = "Num. de control:";
            // 
            // TBXnumcontrol
            // 
            TBXnumcontrol.Location = new Point(245, 69);
            TBXnumcontrol.Name = "TBXnumcontrol";
            TBXnumcontrol.Size = new Size(229, 31);
            TBXnumcontrol.TabIndex = 33;
            // 
            // FrmNuevoAlumno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 46);
            ClientSize = new Size(541, 441);
            Controls.Add(BTNCancelar);
            Controls.Add(BTNguardar);
            Controls.Add(label6);
            Controls.Add(TBXemail);
            Controls.Add(label5);
            Controls.Add(TBXmaterno);
            Controls.Add(label4);
            Controls.Add(TBXpaterno);
            Controls.Add(label3);
            Controls.Add(TBXnombre);
            Controls.Add(label2);
            Controls.Add(TBXnumcontrol);
            Controls.Add(label1);
            Name = "FrmNuevoAlumno";
            Text = "FrmNuevoAlumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BTNCancelar;
        private Button BTNguardar;
        private Label label6;
        private TextBox TBXemail;
        private Label label5;
        private TextBox TBXmaterno;
        private Label label4;
        private TextBox TBXpaterno;
        private Label label3;
        private TextBox TBXnombre;
        private Label label2;
        private TextBox TBXnumcontrol;
    }
}