using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PF_Citamedica
{
    public partial class M_Factura : Form
    {
        static string conexionstring = "Server = LAPTOP-QRH23UM0\\SQLEXPRESS; database = citamedica ; integrated security = true ";
        SqlConnection conexion = new SqlConnection(conexionstring);

        public M_Factura()
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
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            M_addFactura AddFactura = new M_addFactura();
            AddFactura.ShowDialog();

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
                textBox1.Text = reader2["id_pago"].ToString();
                dateTimePicker1.Text = reader2["Fecha_Pago"].ToString();
                textBox3.Text = reader2["tipo_pago"].ToString();
                textBox4.Text = reader2["monto"].ToString();


            }
            conexion.Close();
        }
    }
}
