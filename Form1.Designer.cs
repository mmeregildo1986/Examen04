namespace Examen04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Actualizar = new Button();
            btn_Consultar = new Button();
            btn_Eliminar = new Button();
            dataGridView1 = new DataGridView();
            btn_Agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_Actualizar
            // 
            btn_Actualizar.Location = new Point(259, 15);
            btn_Actualizar.Name = "btn_Actualizar";
            btn_Actualizar.Size = new Size(94, 29);
            btn_Actualizar.TabIndex = 1;
            btn_Actualizar.Text = "Actualizar";
            btn_Actualizar.UseVisualStyleBackColor = true;
            btn_Actualizar.Click += btn_Actualizar_Click;
            // 
            // btn_Consultar
            // 
            btn_Consultar.Location = new Point(159, 15);
            btn_Consultar.Name = "btn_Consultar";
            btn_Consultar.Size = new Size(94, 29);
            btn_Consultar.TabIndex = 2;
            btn_Consultar.Text = "Consultar";
            btn_Consultar.UseVisualStyleBackColor = true;
            btn_Consultar.Click += btn_Consultar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(359, 15);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(94, 29);
            btn_Eliminar.TabIndex = 3;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(686, 214);
            dataGridView1.TabIndex = 4;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(12, 15);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(141, 29);
            btn_Agregar.TabIndex = 5;
            btn_Agregar.Text = "Agregar Producto";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 297);
            Controls.Add(btn_Agregar);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Consultar);
            Controls.Add(btn_Actualizar);
            Name = "Form1";
            Text = "Mantenimiento de Productos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_Actualizar;
        private Button btn_Consultar;
        private Button btn_Eliminar;
        private DataGridView dataGridView1;
        private Button btn_Agregar;
    }
}
