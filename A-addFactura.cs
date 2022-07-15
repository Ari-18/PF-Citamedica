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
    public partial class A_addFactura : Form
    {
        static string conexionstring = "Server = LAPTOP-QRH23UM0\\SQLEXPRESS; database = citamedica ; integrated security = true ";
        SqlConnection conexion = new SqlConnection(conexionstring);
        public A_addFactura()
        {
            InitializeComponent();
        }

        private void A_addFactura_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into Doctor");

            string queryadd = "Insert into Factura (Fecha_Pago, Tipo_Pago, monto) VALUES (@Fecha,  @pago, @Monto)";
            SqlCommand command = new SqlCommand(queryadd, conexion);
            command.Parameters.AddWithValue("@fecha", textBox2.Text);
            command.Parameters.AddWithValue("@pago", textBox3.Text);
            command.Parameters.AddWithValue("@monto", textBox4.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Factura agregada");

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string modificar = "UPDATE Factura SET  Fecha_Pago= @fecha, Tipo_Pago = @tipopago, monto = @Monto WHERE monto = @Monto";
            SqlCommand command2 = new SqlCommand(modificar, conexion);
            command2.Parameters.AddWithValue("@fecha", textBox2.Text);
            command2.Parameters.AddWithValue("@tipopago", textBox3.Text);
            command2.Parameters.AddWithValue("@monto", textBox4.Text);
            command2.ExecuteNonQuery();
            MessageBox.Show("Factura modificado");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string queryde = "DELETE FROM Factura WHERE monto= @Monto ";
            SqlCommand command3 = new SqlCommand(queryde, conexion);
            command3.Parameters.AddWithValue("@Monto", textBox2.Text);

            command3.ExecuteNonQuery();

            MessageBox.Show("Factura eliminado");
        }
    }
}
