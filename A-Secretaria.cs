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

    public partial class Form4 : Form
    {
        static string conexionstring = "Server = LAPTOP-QRH23UM0\\SQLEXPRESS; database = citamedica ; integrated security = true ";
        SqlConnection conexion = new SqlConnection(conexionstring);
        public Form4()
        {
            InitializeComponent();
        }

        public DataTable comboboxsearch()
        {
            SqlDataAdapter command = new SqlDataAdapter("sp_comboboxuser", conexion);
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

        private void Form4_Load(object sender, EventArgs e)
        {
            kilombocombo();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agregar_secreA AgreSecreADM = new Agregar_secreA();
            AgreSecreADM.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand cmd2 = new SqlCommand("select id_usuario, nombre, apellido,  horario, numero_telefono, direccion, correo, sexo, cedula  from usuario where nombre = '" + comboBox1.Text + "'", conexion);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read() == true)
            {
                textid.Text = reader2["id_usuario"].ToString();
                textnombre.Text = reader2["nombre"].ToString();
                textapellido.Text = reader2["apellido"].ToString();
                texthorario.Text = reader2["horario"].ToString();
                textnumero.Text = reader2["numero_telefono"].ToString();
                textdirecc.Text = reader2["direccion"].ToString();
                textcorreo.Text = reader2["correo"].ToString();
                textsexo.Text = reader2["sexo"].ToString();
                textcedula.Text = reader2["cedula"].ToString();

            }
            conexion.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
