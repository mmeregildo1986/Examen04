namespace Examen04
{
    partial class frm_Consultar
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
            btn_BuscarID = new Button();
            dataGridView1 = new DataGridView();
            txtIDCliente = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_BuscarID
            // 
            btn_BuscarID.Location = new Point(26, 79);
            btn_BuscarID.Name = "btn_BuscarID";
            btn_BuscarID.Size = new Size(132, 29);
            btn_BuscarID.TabIndex = 0;
            btn_BuscarID.Text = "Buscar Cliente:";
            btn_BuscarID.UseVisualStyleBackColor = true;
            btn_BuscarID.Click += btn_BuscarID_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(565, 189);
            dataGridView1.TabIndex = 1;
            // 
            // txtIDCliente
            // 
            txtIDCliente.Location = new Point(119, 35);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(125, 27);
            txtIDCliente.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 38);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 3;
            label1.Text = "ID Cliente:";
            // 
            // frm_Consultar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 360);
            Controls.Add(label1);
            Controls.Add(txtIDCliente);
            Controls.Add(dataGridView1);
            Controls.Add(btn_BuscarID);
            Name = "frm_Consultar";
            Text = "frm_Consultar";
            Load += frm_Consultar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_BuscarID;
        private DataGridView dataGridView1;
        private TextBox txtIDCliente;
        private Label label1;
    }
}