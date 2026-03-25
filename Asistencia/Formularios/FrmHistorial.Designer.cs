namespace Asistencia.Formularios
{
    partial class FrmHistorial
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
            DTPhistorial = new DateTimePicker();
            label3 = new Label();
            CBhistorial = new ComboBox();
            label2 = new Label();
            BTNconsultarhistorial = new Button();
            DGVhistorial = new DataGridView();
            label4 = new Label();
            TBXhistorial = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGVhistorial).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(330, 9);
            label1.Name = "label1";
            label1.Size = new Size(422, 35);
            label1.TabIndex = 3;
            label1.Text = "HISTORIAL DE ASISTENCIA";
            // 
            // DTPhistorial
            // 
            DTPhistorial.CalendarFont = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTPhistorial.Location = new Point(688, 70);
            DTPhistorial.Name = "DTPhistorial";
            DTPhistorial.Size = new Size(336, 31);
            DTPhistorial.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(590, 74);
            label3.Name = "label3";
            label3.Size = new Size(82, 26);
            label3.TabIndex = 12;
            label3.Text = "Fecha:";
            label3.Click += label3_Click;
            // 
            // CBhistorial
            // 
            CBhistorial.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CBhistorial.FormattingEnabled = true;
            CBhistorial.Location = new Point(173, 70);
            CBhistorial.Name = "CBhistorial";
            CBhistorial.Size = new Size(366, 35);
            CBhistorial.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(63, 72);
            label2.Name = "label2";
            label2.Size = new Size(104, 26);
            label2.TabIndex = 14;
            label2.Text = "Materia:";
            // 
            // BTNconsultarhistorial
            // 
            BTNconsultarhistorial.BackColor = Color.Lime;
            BTNconsultarhistorial.ForeColor = Color.Black;
            BTNconsultarhistorial.Location = new Point(64, 496);
            BTNconsultarhistorial.Name = "BTNconsultarhistorial";
            BTNconsultarhistorial.Size = new Size(176, 34);
            BTNconsultarhistorial.TabIndex = 17;
            BTNconsultarhistorial.Text = "Consultar";
            BTNconsultarhistorial.UseVisualStyleBackColor = false;
            BTNconsultarhistorial.Click += BTNconsultarhistorial_Click;
            // 
            // DGVhistorial
            // 
            DGVhistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVhistorial.Location = new Point(64, 191);
            DGVhistorial.Name = "DGVhistorial";
            DGVhistorial.RowHeadersWidth = 62;
            DGVhistorial.Size = new Size(960, 277);
            DGVhistorial.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(64, 133);
            label4.Name = "label4";
            label4.Size = new Size(174, 26);
            label4.TabIndex = 18;
            label4.Text = "Buscar alumno:";
            // 
            // TBXhistorial
            // 
            TBXhistorial.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBXhistorial.Location = new Point(244, 133);
            TBXhistorial.Name = "TBXhistorial";
            TBXhistorial.Size = new Size(780, 35);
            TBXhistorial.TabIndex = 19;
            TBXhistorial.TextChanged += TBXhistorial_TextChanged;
            // 
            // FrmHistorial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 46);
            ClientSize = new Size(1083, 570);
            Controls.Add(TBXhistorial);
            Controls.Add(label4);
            Controls.Add(BTNconsultarhistorial);
            Controls.Add(DGVhistorial);
            Controls.Add(CBhistorial);
            Controls.Add(label2);
            Controls.Add(DTPhistorial);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FrmHistorial";
            Text = "FrmHistorial";
            Load += FrmHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)DGVhistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker DTPhistorial;
        private Label label3;
        private ComboBox CBhistorial;
        private Label label2;
        private Button BTNconsultarhistorial;
        private DataGridView DGVhistorial;
        private Label label4;
        private TextBox TBXhistorial;
    }
}