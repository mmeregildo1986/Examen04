using DAO;
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

namespace Examen04
{
    public partial class frm_Eliminar : Form
    {
        public frm_Eliminar()
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

        void EliminarProductos()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                {

                    conexion.Open();
                    SqlCommand command = new SqlCommand("USP_EliminarProducto", conexion);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter parameter1 = new SqlParameter("@Id", SqlDbType.Int);
                    parameter1.Value = Convert.ToInt32(idcliente);
                    command.Parameters.Add(parameter1);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Eliminción exitosa");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        string idcliente;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que la celda clickeada no esté en la fila de encabezados
            if (e.RowIndex >= 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];

                // Colocar los datos de la fila en los TextBox
                idcliente = filaSeleccionada.Cells["IdProducto"].Value.ToString();
                txtIDCliente.Text = filaSeleccionada.Cells["IdProducto"].Value.ToString() + " -- " +

                filaSeleccionada.Cells["Nombre"].Value.ToString() + " -- " +
                filaSeleccionada.Cells["Precio"].Value.ToString() + " -- " +
                filaSeleccionada.Cells["Stock"].Value.ToString();
            }
        }

        private void frm_Eliminar_Load(object sender, EventArgs e)
        {
            listarProductosTotal();
        }

        private void btn_BuscarID_Click(object sender, EventArgs e)
        {
            EliminarProductos();
            listarProductosTotal();
        }
    }
}
