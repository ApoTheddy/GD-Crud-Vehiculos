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
    public partial class Form5 : Form
    {
        private SqlConnection conexion = new SqlConnection("server=. ; database=base1 ; integrated security = true");
        public Form5()
        {
            InitializeComponent();
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            conexion.Open();
            string cod = textBox1.Text;
            string cadena = "Select codigo,descripcion,precio from producto where codigo =" + cod;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            if (registros.Read())
            {
                textBox2.Text = registros["descripcion"].ToString();
                textBox3.Text = registros["precio"].ToString();
            }
            else
            {
                MessageBox.Show("No existe un artículo con el codigo ingresado");
            }
            conexion.Close(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cod = textBox1.Text.Trim();
            string descri = textBox2.Text.Trim();
            string precio = textBox3.Text.Trim();
            string cadena = "delete from producto where codigo=" + cod;

            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Los datos se borraron correctamente");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else
            {
                MessageBox.Show("No existe un artículo con el codigo ingresado");
            }



            conexion.Close();
        }

    }
}
