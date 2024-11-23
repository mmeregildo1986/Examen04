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
    public partial class Form1 : Form
    {
        public Form1()
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
        private void Form1_Load(object sender, EventArgs e)
        {
            listarProductosTotal();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            frm_Agregar frm_Agregar = new frm_Agregar();
            frm_Agregar.Show();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            frm_Consultar frm_Consultar = new frm_Consultar();
            frm_Consultar.Show();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            frm_Actualizar frm_Actualizar = new frm_Actualizar();
            frm_Actualizar.Show();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            frm_Eliminar frm_Eliminar = new frm_Eliminar();
            frm_Eliminar.Show();
        }
    }
}
