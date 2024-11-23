namespace Examen04
{
    partial class frm_Eliminar
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
            txtIDCliente = new TextBox();
            dataGridView1 = new DataGridView();
            btn_BuscarID = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 28);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 7;
            label1.Text = "ID Cliente:";
            // 
            // txtIDCliente
            // 
            txtIDCliente.Location = new Point(109, 25);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(390, 27);
            txtIDCliente.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(709, 189);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btn_BuscarID
            // 
            btn_BuscarID.Location = new Point(520, 28);
            btn_BuscarID.Name = "btn_BuscarID";
            btn_BuscarID.Size = new Size(132, 29);
            btn_BuscarID.TabIndex = 4;
            btn_BuscarID.Text = "Eliminar Producto:";
            btn_BuscarID.UseVisualStyleBackColor = true;
            btn_BuscarID.Click += btn_BuscarID_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(259, 20);
            label2.TabIndex = 8;
            label2.Text = "SELECCIONE PRODUCTO A ELIMINAR:";
            // 
            // frm_Eliminar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 310);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIDCliente);
            Controls.Add(dataGridView1);
            Controls.Add(btn_BuscarID);
            Name = "frm_Eliminar";
            Text = "frm_Eliminar";
            Load += frm_Eliminar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIDCliente;
        private DataGridView dataGridView1;
        private Button btn_BuscarID;
        private Label label2;
    }
}