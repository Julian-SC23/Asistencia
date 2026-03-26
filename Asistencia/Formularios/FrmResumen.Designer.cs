namespace Asistencia.Formularios
{
    partial class FrmResumen
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
            CBhistorial = new ComboBox();
            label2 = new Label();
            label10 = new Label();
            TBXmin = new TextBox();
            BTNconsultar = new Button();
            label1 = new Label();
            DGVresumen = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVresumen).BeginInit();
            SuspendLayout();
            // 
            // CBhistorial
            // 
            CBhistorial.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CBhistorial.FormattingEnabled = true;
            CBhistorial.Location = new Point(154, 96);
            CBhistorial.Name = "CBhistorial";
            CBhistorial.Size = new Size(366, 35);
            CBhistorial.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(44, 98);
            label2.Name = "label2";
            label2.Size = new Size(104, 26);
            label2.TabIndex = 16;
            label2.Text = "Materia:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(546, 102);
            label10.Name = "label10";
            label10.Size = new Size(94, 26);
            label10.TabIndex = 36;
            label10.Text = "Min %:";
            // 
            // TBXmin
            // 
            TBXmin.Location = new Point(655, 100);
            TBXmin.Name = "TBXmin";
            TBXmin.Size = new Size(127, 31);
            TBXmin.TabIndex = 35;
            // 
            // BTNconsultar
            // 
            BTNconsultar.BackColor = Color.DodgerBlue;
            BTNconsultar.ForeColor = Color.Transparent;
            BTNconsultar.Location = new Point(821, 100);
            BTNconsultar.Name = "BTNconsultar";
            BTNconsultar.Size = new Size(112, 34);
            BTNconsultar.TabIndex = 42;
            BTNconsultar.Text = "Consultar";
            BTNconsultar.UseVisualStyleBackColor = false;
            BTNconsultar.Click += BTNconsultar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(425, 31);
            label1.Name = "label1";
            label1.Size = new Size(166, 35);
            label1.TabIndex = 43;
            label1.Text = "RESUMEN";
            // 
            // DGVresumen
            // 
            DGVresumen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVresumen.Location = new Point(44, 165);
            DGVresumen.Name = "DGVresumen";
            DGVresumen.RowHeadersWidth = 62;
            DGVresumen.Size = new Size(889, 277);
            DGVresumen.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Lime;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(89, 474);
            label3.Name = "label3";
            label3.Size = new Size(59, 26);
            label3.TabIndex = 45;
            label3.Text = "Bien";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkOrange;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(173, 474);
            label4.Name = "label4";
            label4.Size = new Size(80, 26);
            label4.TabIndex = 46;
            label4.Text = "Riesgo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Red;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(279, 474);
            label5.Name = "label5";
            label5.Size = new Size(126, 26);
            label5.TabIndex = 47;
            label5.Text = "Reprobado";
            // 
            // FrmResumen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 46);
            ClientSize = new Size(994, 538);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(DGVresumen);
            Controls.Add(label1);
            Controls.Add(BTNconsultar);
            Controls.Add(label10);
            Controls.Add(TBXmin);
            Controls.Add(CBhistorial);
            Controls.Add(label2);
            Name = "FrmResumen";
            Text = "FrmResumen";
            Load += FrmResumen_Load;
            ((System.ComponentModel.ISupportInitialize)DGVresumen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CBhistorial;
        private Label label2;
        private Label label10;
        private TextBox TBXmin;
        private Button BTNconsultar;
        private Label label1;
        private DataGridView DGVresumen;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}