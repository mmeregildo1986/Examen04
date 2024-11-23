namespace Examen04
{
    partial class frm_Actualizar
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
            txtID = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            txtNom = new TextBox();
            label3 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            txtStock = new TextBox();
            btn_ActualizarProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 17);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 7;
            label1.Text = "ID Cliente:";
            // 
            // txtID
            // 
            txtID.Location = new Point(107, 10);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 189);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(679, 189);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 50);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 9;
            label2.Text = "Nombre:";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(107, 43);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(125, 27);
            txtNom.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 83);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 11;
            label3.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(107, 76);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 116);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 13;
            label4.Text = "Stock:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(107, 109);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 12;
            // 
            // btn_ActualizarProducto
            // 
            btn_ActualizarProducto.Location = new Point(14, 154);
            btn_ActualizarProducto.Name = "btn_ActualizarProducto";
            btn_ActualizarProducto.Size = new Size(146, 29);
            btn_ActualizarProducto.TabIndex = 14;
            btn_ActualizarProducto.Text = "Actualizar Producto:";
            btn_ActualizarProducto.UseVisualStyleBackColor = true;
            btn_ActualizarProducto.Click += btn_ActualizarProducto_Click;
            // 
            // frm_Actualizar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 397);
            Controls.Add(btn_ActualizarProducto);
            Controls.Add(label4);
            Controls.Add(txtStock);
            Controls.Add(label3);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(txtNom);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(dataGridView1);
            Name = "frm_Actualizar";
            Text = "Actualizar Producto:";
            Load += frm_Actualizar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox txtNom;
        private Label label3;
        private TextBox txtPrecio;
        private Label label4;
        private TextBox txtStock;
        private Button btn_ActualizarProducto;
    }
}