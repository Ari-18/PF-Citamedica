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

    public partial class Form3 : Form
    {
        string conexionstring = "Server = LAPTOP-QRH23UM0\\SQLEXPRESS; database = citamedica ; integrated security = true ";
        SqlConnection conexion = new SqlConnection();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into Doctor");

            //string queryadd = "Insert into Chofer (cedula_chofer, Nombre_chofer, Apellido_chofer, Fecha_nacimiento) VALUES (@Cedula, @Nombre, @Apellido, @Fecha)";
            //SqlCommand command = new SqlCommand(queryadd, conexion);
            //command.Parameters.AddWithValue("@Cedula", textCedu.Text);
            //command.Parameters.AddWithValue("@Nombre", textNom.Text);
            //command.Parameters.AddWithValue("@Apellido", textApe.Text);
            //command.Parameters.AddWithValue("@Fecha", textNac.Text);

            //command.ExecuteNonQuery();
            //MessageBox.Show("Doctor agregado ");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string modificar = "UPDATE Doctor SET  nombre= @Nombre, apellido= @Apellido, edad = @Edad, Fecha_Nacimiento= @Fecha,  Numero_telefono = @Numero, Especialidad = @especialidad, horario = @ Horario, sexo = @Sexo WHERE nombre =@Nombre ";
            SqlCommand command2 = new SqlCommand(modificar, conexion);
            command2.Parameters.AddWithValue("@Nombre", textBox2.Text);
            command2.Parameters.AddWithValue("@Apellido", textBox3.Text);
            command2.Parameters.AddWithValue("@Edad", textBox4.Text);
            command2.Parameters.AddWithValue("@Fecha", dateTimePicker1.Text);
            command2.Parameters.AddWithValue("@Numero", textBox6.Text);
            command2.Parameters.AddWithValue("@especialidad", textBox7.Text);
            command2.Parameters.AddWithValue("@horario", textBox8.Text);
            command2.Parameters.AddWithValue("@sexo", textsexo.Text);
            command2.ExecuteNonQuery();
            MessageBox.Show("Doctor modificado");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Conexion.Conectar();
            //string queryde = "DELETE FROM Chofer WHERE cedula_chofer =@Cedula";
            //SqlCommand command3 = new SqlCommand(queryde, Conexion.Conectar());
            //command3.Parameters.AddWithValue("@Cedula", textCedu.Text);

            //command3.ExecuteNonQuery();

            //MessageBox.Show("Chofer eliminado");
            //dataGridView1.DataSource = llenado_grid();
        }
    }
}
