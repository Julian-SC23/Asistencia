namespace Asistencia.Formularios
{
    partial class FrmMaterias
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
            DGVmaterias = new DataGridView();
            BTNeliminar = new Button();
            BTNnuevo = new Button();
            TBXbuscmaterias = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVmaterias).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(44, 97);
            label2.Name = "label2";
            label2.Size = new Size(98, 26);
            label2.TabIndex = 13;
            label2.Text = "Buscar: ";
            // 
            // DGVmaterias
            // 
            DGVmaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmaterias.Location = new Point(44, 165);
            DGVmaterias.Name = "DGVmaterias";
            DGVmaterias.RowHeadersWidth = 62;
            DGVmaterias.Size = new Size(876, 225);
            DGVmaterias.TabIndex = 12;
            // 
            // BTNeliminar
            // 
            BTNeliminar.BackColor = Color.Red;
            BTNeliminar.ForeColor = Color.Black;
            BTNeliminar.Location = new Point(808, 95);
            BTNeliminar.Name = "BTNeliminar";
            BTNeliminar.Size = new Size(112, 34);
            BTNeliminar.TabIndex = 11;
            BTNeliminar.Text = "Eliminar";
            BTNeliminar.UseVisualStyleBackColor = false;
            // 
            // BTNnuevo
            // 
            BTNnuevo.BackColor = Color.Lime;
            BTNnuevo.ForeColor = Color.Black;
            BTNnuevo.Location = new Point(655, 93);
            BTNnuevo.Name = "BTNnuevo";
            BTNnuevo.Size = new Size(112, 34);
            BTNnuevo.TabIndex = 10;
            BTNnuevo.Text = "Nuevo";
            BTNnuevo.UseVisualStyleBackColor = false;
            // 
            // TBXbuscmaterias
            // 
            TBXbuscmaterias.Location = new Point(148, 95);
            TBXbuscmaterias.Name = "TBXbuscmaterias";
            TBXbuscmaterias.Size = new Size(466, 31);
            TBXbuscmaterias.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(407, 24);
            label1.Name = "label1";
            label1.Size = new Size(174, 35);
            label1.TabIndex = 8;
            label1.Text = "MATERIAS";
            // 
            // FrmMaterias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 36);
            ClientSize = new Size(975, 433);
            Controls.Add(label2);
            Controls.Add(DGVmaterias);
            Controls.Add(BTNeliminar);
            Controls.Add(BTNnuevo);
            Controls.Add(TBXbuscmaterias);
            Controls.Add(label1);
            Name = "FrmMaterias";
            Text = "FrmMaterias";
            Load += FrmMaterias_Load;
            ((System.ComponentModel.ISupportInitialize)DGVmaterias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView DGVmaterias;
        private Button BTNeliminar;
        private Button BTNnuevo;
        private TextBox TBXbuscmaterias;
        private Label label1;
    }
}