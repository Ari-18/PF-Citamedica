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
    public partial class M_addFactura : Form
    {
        static string conexionstring = "Server = LAPTOP-QRH23UM0\\SQLEXPRESS; database = citamedica ; integrated security = true ";
        SqlConnection conexion = new SqlConnection(conexionstring);
        public M_addFactura()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string queryde = "DELETE FROM nombre WHERE nombre= @Nombre ";
            SqlCommand command3 = new SqlCommand(queryde, conexion);
            command3.Parameters.AddWithValue("@Fecha", textBox2.Text);

            command3.ExecuteNonQuery();

            MessageBox.Show("Factura eliminada ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into Factura");

            string queryadd = "Insert into Chofer (Fecha_Pago, tipo_pago, mont0) VALUES (@Fecha,  @Forma, @Monto )";
            SqlCommand command = new SqlCommand(queryadd, conexion);
            command.Parameters.AddWithValue("@Fecha", textBox2.Text);
            command.Parameters.AddWithValue("@Forma", textBox3.Text);
            command.Parameters.AddWithValue("@Monto", textBox4.Text);

            command.ExecuteNonQuery();
            MessageBox.Show("Factura agregada");

        }
    }
}
