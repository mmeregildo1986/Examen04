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
using System.Xml.Linq;

namespace Examen04
{
    public partial class frm_Agregar : Form
    {
        public frm_Agregar()
        {
            InitializeComponent();
        }

        void InsertarProductos()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                {

                    conexion.Open();
                    SqlCommand command = new SqlCommand("USP_InsertarProducto", conexion);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter parameter1 = new SqlParameter("@Nombre", SqlDbType.VarChar, 50);
                    parameter1.Value = txtNom.Text;
                    SqlParameter parameter2 = new SqlParameter("@Precio", SqlDbType.Decimal, 10);
                    parameter2.Value = Convert.ToDecimal(txtPrecio.Text);
                    SqlParameter parameter3 = new SqlParameter("@Stock", SqlDbType.Int);
                    parameter3.Value = Convert.ToInt32(txtStock.Text);
                    SqlParameter parameter4 = new SqlParameter("@FechaCreacion", SqlDbType.DateTime);
                    parameter4.Value = DateTime.Now;
                    command.Parameters.Add(parameter1);
                    command.Parameters.Add(parameter2);
                    command.Parameters.Add(parameter3);
                    command.Parameters.Add(parameter4);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Registro exitoso");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            InsertarProductos();
        }

        private void frm_Agregar_Load(object sender, EventArgs e)
        {

        }
    }
}
