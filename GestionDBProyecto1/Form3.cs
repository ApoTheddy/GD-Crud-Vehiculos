using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion12_YBCR
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=. ; database=base1 ; integrated security = true");
            conexion.Open();
            string cod = textBox1.Text;
            string cadena = "Select codigo,descripcion,precio from producto where codigo =" + cod;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            if (registros.Read())
            {
                label4.Text = registros["descripcion"].ToString();
                label5.Text = registros["precio"].ToString();
            }
            else
            {
                MessageBox.Show("No existe un artículo con el codigo ingresado");
            }
            conexion.Close();
        }
    }
}
