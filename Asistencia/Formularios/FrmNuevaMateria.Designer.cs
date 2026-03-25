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
            label1 = new Label();
            SuspendLayout();
            // 
            // BTNCancelar
            // 
            BTNCancelar.BackColor = Color.Red;
            BTNCancelar.ForeColor = Color.Black;
            BTNCancelar.Location = new Point(281, 377);
            BTNCancelar.Name = "BTNCancelar";
            BTNCancelar.Size = new Size(112, 34);
            BTNCancelar.TabIndex = 32;
            BTNCancelar.Text = "Cancelar";
            BTNCancelar.UseVisualStyleBackColor = false;
            // 
            // BTNguardar
            // 
            BTNguardar.BackColor = Color.Lime;
            BTNguardar.ForeColor = Color.Black;
            BTNguardar.Location = new Point(128, 375);
            BTNguardar.Name = "BTNguardar";
            BTNguardar.Size = new Size(112, 34);
            BTNguardar.TabIndex = 31;
            BTNguardar.Text = "Guardar";
            BTNguardar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(55, 320);
            label6.Name = "label6";
            label6.Size = new Size(81, 26);
            label6.TabIndex = 30;
            label6.Text = "Email:";
            // 
            // TBXemail
            // 
            TBXemail.Location = new Point(142, 315);
            TBXemail.Name = "TBXemail";
            TBXemail.Size = new Size(333, 31);
            TBXemail.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(55, 265);
            label5.Name = "label5";
            label5.Size = new Size(152, 26);
            label5.TabIndex = 28;
            label5.Text = "Ap. Materno:";
            // 
            // TBXmaterno
            // 
            TBXmaterno.Location = new Point(213, 263);
            TBXmaterno.Name = "TBXmaterno";
            TBXmaterno.Size = new Size(262, 31);
            TBXmaterno.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(55, 210);
            label4.Name = "label4";
            label4.Size = new Size(144, 26);
            label4.TabIndex = 26;
            label4.Text = "Ap. Paterno:";
            // 
            // TBXpaterno
            // 
            TBXpaterno.Location = new Point(205, 208);
            TBXpaterno.Name = "TBXpaterno";
            TBXpaterno.Size = new Size(270, 31);
            TBXpaterno.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(55, 155);
            label3.Name = "label3";
            label3.Size = new Size(103, 26);
            label3.TabIndex = 24;
            label3.Text = "Nombre:";
            // 
            // TBXnombre
            // 
            TBXnombre.Location = new Point(164, 153);
            TBXnombre.Name = "TBXnombre";
            TBXnombre.Size = new Size(311, 31);
            TBXnombre.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(55, 100);
            label2.Name = "label2";
            label2.Size = new Size(185, 26);
            label2.TabIndex = 22;
            label2.Text = "Num. de control:";
            // 
            // TBXnumcontrol
            // 
            TBXnumcontrol.Location = new Point(246, 98);
            TBXnumcontrol.Name = "TBXnumcontrol";
            TBXnumcontrol.Size = new Size(229, 31);
            TBXnumcontrol.TabIndex = 21;
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
            // FrmNuevaMateria
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 36);
            ClientSize = new Size(540, 450);
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
            Name = "FrmNuevaMateria";
            Text = "FrmNuevaMateria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Label label1;
    }
}