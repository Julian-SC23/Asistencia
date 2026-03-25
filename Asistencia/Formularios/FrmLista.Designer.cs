namespace Asistencia.Formularios
{
    partial class FrmLista
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
            CBmaterias = new ComboBox();
            label3 = new Label();
            DTPpasedelista = new DateTimePicker();
            DGVlista = new DataGridView();
            BTNguardarlista = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVlista).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(439, 9);
            label1.Name = "label1";
            label1.Size = new Size(205, 41);
            label1.TabIndex = 2;
            label1.Text = "Pase de lista";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(47, 78);
            label2.Name = "label2";
            label2.Size = new Size(104, 26);
            label2.TabIndex = 8;
            label2.Text = "Materia:";
            // 
            // CBmaterias
            // 
            CBmaterias.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CBmaterias.FormattingEnabled = true;
            CBmaterias.Location = new Point(157, 76);
            CBmaterias.Name = "CBmaterias";
            CBmaterias.Size = new Size(366, 35);
            CBmaterias.TabIndex = 9;
            CBmaterias.SelectedIndexChanged += CBmaterias_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(573, 84);
            label3.Name = "label3";
            label3.Size = new Size(82, 26);
            label3.TabIndex = 10;
            label3.Text = "Fecha:";
            // 
            // DTPpasedelista
            // 
            DTPpasedelista.CalendarFont = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTPpasedelista.Location = new Point(671, 80);
            DTPpasedelista.Name = "DTPpasedelista";
            DTPpasedelista.Size = new Size(336, 31);
            DTPpasedelista.TabIndex = 11;
            // 
            // DGVlista
            // 
            DGVlista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVlista.Location = new Point(47, 137);
            DGVlista.Name = "DGVlista";
            DGVlista.RowHeadersWidth = 62;
            DGVlista.Size = new Size(960, 277);
            DGVlista.TabIndex = 12;
            // 
            // BTNguardarlista
            // 
            BTNguardarlista.BackColor = Color.Lime;
            BTNguardarlista.ForeColor = Color.Black;
            BTNguardarlista.Location = new Point(47, 442);
            BTNguardarlista.Name = "BTNguardarlista";
            BTNguardarlista.Size = new Size(176, 34);
            BTNguardarlista.TabIndex = 13;
            BTNguardarlista.Text = "Guardar lista";
            BTNguardarlista.UseVisualStyleBackColor = false;
            BTNguardarlista.Click += BTNguardarlista_Click;
            // 
            // FrmLista
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 46);
            ClientSize = new Size(1055, 511);
            Controls.Add(BTNguardarlista);
            Controls.Add(DGVlista);
            Controls.Add(DTPpasedelista);
            Controls.Add(label3);
            Controls.Add(CBmaterias);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmLista";
            Text = "FrmLista";
            Load += FrmLista_Load;
            ((System.ComponentModel.ISupportInitialize)DGVlista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox CBmaterias;
        private Label label3;
        private DateTimePicker DTPpasedelista;
        private DataGridView DGVlista;
        private Button BTNguardarlista;
    }
}