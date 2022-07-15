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
        static string conexionstring = "Server = LAPTOP-QRH23UM0\\SQLEXPRESS; database = citamedica ; integrated security = true ";
        SqlConnection conexion = new SqlConnection(conexionstring);
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

            string queryadd = "Insert into Chofer (nombre, apellido, edad, Fecha_Nacimiento, Numero_telefono, Especialidad , horario ,sexo ) VALUES (@Nombre,  @Apellido, @Edad @Fecha, @Numero, @especialidad, @Horario, @Sexo)";
            SqlCommand command = new SqlCommand(queryadd, conexion);
            command.Parameters.AddWithValue("@Nombre", textBox2.Text);
            command.Parameters.AddWithValue("@Apellido", textBox3.Text);
            command.Parameters.AddWithValue("@Edad", textBox4.Text);
            command.Parameters.AddWithValue("@Fecha", dateTimePicker1.Text);
            command.Parameters.AddWithValue("@Numero", textBox6.Text);
            command.Parameters.AddWithValue("@especialidad", textBox7.Text);
            command.Parameters.AddWithValue("@Horario", textBox8.Text);
            command.Parameters.AddWithValue("@Sexo", textsexo.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Doctor agregado ");



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
          
            string queryde = "DELETE FROM nombre WHERE nombre= @Nombre ";
            SqlCommand command3 = new SqlCommand(queryde, conexion);
            command3.Parameters.AddWithValue("@Nombre", textBox2.Text);

            command3.ExecuteNonQuery();

            MessageBox.Show("Doctor eliminado");
           
        }
    }
}
