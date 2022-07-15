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
    public partial class M_AgregarCita : Form

    {
        static string conexionstring = "Server = LAPTOP-QRH23UM0\\SQLEXPRESS; database = citamedica ; integrated security = true ";
        SqlConnection conexion = new SqlConnection(conexionstring);
        public M_AgregarCita()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand sqlCommand = new SqlCommand("insert into cita");

            string queryadd = "Insert into Chofer (Fecha_cita, hora, ) VALUES (@Fecha,  @hora,)";
            SqlCommand command = new SqlCommand(queryadd, conexion);
            command.Parameters.AddWithValue("@Fecha", dateTimePicker1.Text);
            command.Parameters.AddWithValue("@hora", dateTimePicker2.Text);

           
                command.ExecuteNonQuery();
            MessageBox.Show("Cita agregada");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        { 
            string queryde = "DELETE FROM nombre WHERE nombre= @Nombre ";
            SqlCommand command3 = new SqlCommand(queryde, conexion);
            command3.Parameters.AddWithValue("fecha", dateTimePicker1.Text);

            command3.ExecuteNonQuery();

            MessageBox.Show("Cita eliminada");

        }
    }
}
