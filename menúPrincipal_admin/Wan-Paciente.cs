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
    public partial class Wan_Paciente : Form
    {
        static string conexionstring = "Server = LAPTOP-QRH23UM0\\SQLEXPRESS; database = citamedica ; integrated security = true ";
        SqlConnection conexion = new SqlConnection(conexionstring);
   
        public Wan_Paciente()
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

        void kilombocombo()
        {

            comboBox1.DataSource = comboboxsearch();
            comboBox1.DisplayMember = "nombre";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wan_AgregarPaciente agregarPaciente = new Wan_AgregarPaciente();
            agregarPaciente.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Wan_Paciente_Load(object sender, EventArgs e)
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
                textid.Text = reader2["id_paciente"].ToString();
                textnombre.Text = reader2["nombre"].ToString();
                textapellido.Text = reader2["apellido"].ToString();
                textedad.Text = reader2["edad"].ToString();
                dateTimePicker3.Text = reader2["Fecha_Nacimiento"].ToString();
                textSocial.Text = reader2["Seguro_social"].ToString();
                texttelefono.Text = reader2["Numero_telefono"].ToString();
                textdirec.Text = reader2["direccion"].ToString();
                textprov.Text = reader2["provincia"].ToString();
                textsexo.Text = reader2["sexo"].ToString();

            }
            conexion.Close();
        }
    }
}
