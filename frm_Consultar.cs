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
    public partial class frm_Consultar : Form
    {
        public frm_Consultar()
        {
            InitializeComponent();
        }

        private void btn_BuscarID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDCliente.Text))
            { MessageBox.Show("Ingresa un Id de Producto"); txtIDCliente.Focus(); }
            else
            { dataGridView1.DataSource = DatosProductos.listarClientes(txtIDCliente.Text); }


        }

        private void frm_Consultar_Load(object sender, EventArgs e)
        {

        }
    }
}
