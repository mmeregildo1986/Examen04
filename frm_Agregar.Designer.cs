namespace Examen04
{
    partial class frm_Agregar
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
            txtNom = new TextBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            btn_Grabar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtNom
            // 
            txtNom.Location = new Point(104, 45);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(125, 27);
            txtNom.TabIndex = 0;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(104, 111);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(104, 78);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 2;
            // 
            // btn_Grabar
            // 
            btn_Grabar.Location = new Point(43, 162);
            btn_Grabar.Name = "btn_Grabar";
            btn_Grabar.Size = new Size(94, 29);
            btn_Grabar.TabIndex = 3;
            btn_Grabar.Text = "Grabar";
            btn_Grabar.UseVisualStyleBackColor = true;
            btn_Grabar.Click += btn_Grabar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 43);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 81);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 5;
            label2.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 118);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 6;
            label3.Text = "Stock:";
            // 
            // frm_Agregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 224);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Grabar);
            Controls.Add(txtPrecio);
            Controls.Add(txtStock);
            Controls.Add(txtNom);
            Name = "frm_Agregar";
            Text = "frm_Agregar";
            Load += frm_Agregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNom;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private Button btn_Grabar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}