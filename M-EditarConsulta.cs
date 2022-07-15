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
    public partial class M_EditarConsulta : Form

    {
        static string conexionstring = "Server = LAPTOP-QRH23UM0\\SQLEXPRESS; database = citamedica ; integrated security = true ";
        SqlConnection conexion = new SqlConnection(conexionstring);
        public M_EditarConsulta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string queryde = "DELETE FROM nombre WHERE nombre= @Nombre ";
            SqlCommand command3 = new SqlCommand(queryde, conexion);
            command3.Parameters.AddWithValue("@Consulta", textBox2.Text);

            command3.ExecuteNonQuery();

            MessageBox.Show("modificacion  Cancelada");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string modificar = "UPDATE Doctor SET  Descripcion_Consulta= @Consulta, Diagnostico= @Diagnotico, Receta= @Receta, tipo_Consulta= @Tipo ";
            SqlCommand command2 = new SqlCommand(modificar, conexion);
            command2.Parameters.AddWithValue("@Consulta", textBox2.Text);
            command2.Parameters.AddWithValue("@Diagnostico", textBox3.Text);
            command2.Parameters.AddWithValue("@Receta", textBox4.Text);
            command2.Parameters.AddWithValue("@Tipo", textBox5.Text);

            MessageBox.Show("Consulta modificada");

        }
    }
}
