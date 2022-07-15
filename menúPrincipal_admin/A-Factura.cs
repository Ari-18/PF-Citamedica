using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PF_Citamedica
{
    public partial class A_Factura : Form
    {
        static string conexionstring = "Server = LAPTOP-QRH23UM0\\SQLEXPRESS; database = citamedica ; integrated security = true ";
        SqlConnection conexion = new SqlConnection(conexionstring);

        public A_Factura()
        {
            InitializeComponent();
        }

        public DataTable comboboxsearch()
        {
            SqlDataAdapter command = new SqlDataAdapter("sp_comboboxfact ", conexion);
            command.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            command.Fill(tabla);

            return tabla;
        }

        void kilombocombo()
        {

            comboBox1.DataSource = comboboxsearch();
            comboBox1.DisplayMember = "id_pago";
        }
        private void button1_Click(object sender, EventArgs e)
        {
           A_addFactura frm = new A_addFactura();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void A_Factura_Load(object sender, EventArgs e)
        {
            kilombocombo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand cmd2 = new SqlCommand("Select id_pago, Fecha_Pago, tipo_pago, monto from Factura where id_pago = '" + comboBox1.Text + "'", conexion);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read() == true)
            {
                textID.Text = reader2["id_pago"].ToString();
                dateTimePicker1.Text = reader2["Fecha_Pago"].ToString();
                textformap.Text = reader2["tipo_pago"].ToString();
                textmonto.Text = reader2["monto"].ToString();
               

            }
            conexion.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textformap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
