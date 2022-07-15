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
    public partial class M_Paciente : Form
    {
        static string conexionstring = "Server = LAPTOP-QRH23UM0\\SQLEXPRESS; database = citamedica ; integrated security = true ";
        SqlConnection conexion = new SqlConnection(conexionstring);

        public M_Paciente()
        {
            InitializeComponent();
        }
        public DataTable comboboxsearch()
        {
            SqlDataAdapter command = new SqlDataAdapter("sp_comboboxpaciente", conexion);
            command.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            command.Fill(tabla);

            return tabla;
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        void kilombocombo()
        {

            comboBox1.DataSource = comboboxsearch();
            comboBox1.DisplayMember = "nombre";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            M_AgregarPaciente agregarPaciente = new M_AgregarPaciente();
            agregarPaciente.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            


        }
        private void M_Paciente_Load(object sender, EventArgs e)
        {
            kilombocombo();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand cmd2 = new SqlCommand("select id_paciente, nombre,  apellido, edad,  Fecha_Nacimiento, Seguro_social, Numero_telefono, direccion, provincia, sexo from paciente where nombre = '" + comboBox1.Text + "'", conexion);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read() == true)
            {
                textBox1.Text = reader2["id_paciente"].ToString();
                textBox2.Text = reader2["nombre"].ToString();
                textBox3.Text = reader2["apellido"].ToString();
                textBox4.Text = reader2["edad"].ToString();
                dateTimePicker1.Text = reader2["Fecha_Nacimiento"].ToString();
                textBox5.Text = reader2["Seguro_social"].ToString();
                textBox6.Text = reader2["Numero_telefono"].ToString();
                textBox7.Text = reader2["direccion"].ToString();
                textBox8.Text = reader2["provincia"].ToString();
                textsexo.Text = reader2["sexo"].ToString();

            }
            conexion.Close();
        }
    }
}
