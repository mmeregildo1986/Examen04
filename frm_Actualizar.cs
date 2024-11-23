using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace Examen04
{
    public partial class frm_Actualizar : Form
    {
        public frm_Actualizar()
        {
            InitializeComponent();
        }

        void listarProductosTotal()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                {

                    SqlCommand command = new SqlCommand("USP_ListarProductoTotal", conexion);
                    command.CommandType = CommandType.StoredProcedure;
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void ActualizarProductos()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                {

                    conexion.Open();
                    SqlCommand command = new SqlCommand("USP_ActualizarProducto", conexion);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter parameter1 = new SqlParameter("@Id", SqlDbType.Int);
                    parameter1.Value = Convert.ToInt32(txtID.Text);
                    SqlParameter parameter2 = new SqlParameter("@Nombre", SqlDbType.NVarChar, 50);
                    parameter2.Value = txtNom.Text;
                    SqlParameter parameter3 = new SqlParameter("@Precio", SqlDbType.Decimal, 10);
                    parameter3.Value = Convert.ToDecimal(txtPrecio.Text);
                    SqlParameter parameter4 = new SqlParameter("@Stock", SqlDbType.Int);
                    parameter4.Value = Convert.ToInt32(txtStock.Text);
                    command.Parameters.Add(parameter1);
                    command.Parameters.Add(parameter2);
                    command.Parameters.Add(parameter3);
                    command.Parameters.Add(parameter4);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Actualizacion exitosa");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void frm_Actualizar_Load(object sender, EventArgs e)
        {
            listarProductosTotal();
            DesabilitarTextbox();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que la celda clickeada no esté en la fila de encabezados
            if (e.RowIndex >= 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];

                // Colocar los datos de la fila en los TextBox
                txtID.Text = filaSeleccionada.Cells["IdProducto"].Value.ToString();
                txtNom.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                txtPrecio.Text = filaSeleccionada.Cells["Precio"].Value.ToString();
                txtStock.Text = filaSeleccionada.Cells["Stock"].Value.ToString();

            }
            EditarTextbox();
        }

        void DesabilitarTextbox()
        {
            txtID.ReadOnly = true;
            txtNom.ReadOnly = true;
            txtPrecio.ReadOnly = true;
            txtStock.ReadOnly = true;
        }
        void EditarTextbox()
        {
            txtID.ReadOnly = true;
            txtNom.ReadOnly = false;
            txtPrecio.ReadOnly = false;
            txtStock.ReadOnly = false;
        }
        private void btn_ActualizarProducto_Click(object sender, EventArgs e)
        {
            ActualizarProductos();
            listarProductosTotal();
            DesabilitarTextbox();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
