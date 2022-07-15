

using System.Data;
using System.Data.SqlClient;
namespace PF_Citamedica
{
    public partial class WG_doctor : Form
    {
        static string conexionstring = "Server = LAPTOP-QRH23UM0\\SQLEXPRESS; database = citamedica ; integrated security = true ";
        SqlConnection conexion = new SqlConnection(conexionstring);


        public WG_doctor()
        {
            InitializeComponent();
        }
        public DataTable comboboxsearch()
        {
            SqlDataAdapter command = new SqlDataAdapter("sp_comboboxDoc", conexion);
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
        private void Form1_Load(object sender, EventArgs e)
        {
            kilombocombo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WG_ver AgregarDoctor = new WG_ver();
            AgregarDoctor.ShowDialog(); 

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand cmd2 = new SqlCommand("select id_medico, nombre ,  apellido,edad, Fecha_Nacimiento, Numero_telefono, Especialidad ,  horario ,sexo from Doctor where nombre = '" + comboBox1.Text + "'", conexion);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read() == true)
            {
                textBox1.Text = reader2["id_medico"].ToString();
                textBox2.Text = reader2["nombre"].ToString();
                textBox3.Text = reader2["apellido"].ToString();
                textBox4.Text = reader2["edad"].ToString();
                dateTimePicker1.Text = reader2["Fecha_Nacimiento"].ToString();
                textnumero.Text = reader2["Numero_telefono"].ToString();
                textespecial.Text = reader2["Especialidad"].ToString();
                texthorario.Text = reader2["horario"].ToString();
                textsexo.Text = reader2["sexo"].ToString();
             
            }
            conexion.Close();
        }
    }
}