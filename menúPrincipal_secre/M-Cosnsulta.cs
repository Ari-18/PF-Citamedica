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
    public partial class M_Cosnsulta : Form
    {
        static string conexionstring = "Server = LAPTOP-QRH23UM0\\SQLEXPRESS; database = citamedica ; integrated security = true ";
        SqlConnection conexion = new SqlConnection(conexionstring);
        public M_Cosnsulta()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public DataTable comboboxsearch()
        {
            SqlDataAdapter Adaptador = new SqlDataAdapter("sp_comboboxconsulta", conexion);
            Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            Adaptador.Fill(tabla);

            return tabla;
        }   
            private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void kilombocombo()
        {

            comboBox1.DataSource = comboboxsearch();
            comboBox1.DisplayMember = "Diagnostico";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            M_EditarConsulta editarConsulta = new M_EditarConsulta();
            editarConsulta.ShowDialog(); 

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand cmd2 = new SqlCommand("select id_consulta, Descripcion_Consulta, Diagnostico, Receta, tipo_consulta from Consulta where Diagnostico = '" + comboBox1.Text + "'", conexion);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read() == true)
            {
                textBox1.Text = reader2["id_consulta"].ToString();
                textBox2.Text = reader2["Descripcion_Consulta"].ToString();
                textBox3.Text = reader2["Diagnostico"].ToString();
                textBox4.Text = reader2["Receta"].ToString();
                textBox5.Text = reader2["tipo_consulta"].ToString();


            }
            conexion.Close();
        }
    }
}
