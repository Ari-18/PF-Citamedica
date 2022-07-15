﻿using System;
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
    public partial class Wan_Cita : Form
    {
        static string conexionstring = "Server = LAPTOP-QRH23UM0\\SQLEXPRESS; database = citamedica ; integrated security = true ";
        SqlConnection conexion = new SqlConnection(conexionstring);

        public Wan_Cita()
        {
            InitializeComponent();
        }

        public DataTable comboboxsearch()
        {
            SqlDataAdapter command = new SqlDataAdapter("sp_comboboxcita2", conexion);
            command.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            command.Fill(tabla);

            return tabla;
        }

        void kilombocombo()
        {

            comboBox1.DataSource = comboboxsearch();
            comboBox1.DisplayMember = "mes";
        }

        private void Wan_Cita_Load(object sender, EventArgs e)
        {
            kilombocombo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PF_Citamedica.W_AddCita AgregarCita = new PF_Citamedica.W_AddCita();
            AgregarCita.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand cmd2 = new SqlCommand("select id_cita, Fecha_cita, hora, mes  from cita where mes = '" + comboBox1.Text + "'", conexion);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read() == true)
            {
                textid.Text = reader2["id_cita"].ToString();
                dateTimePicker1.Text = reader2["Fecha_cita"].ToString();
                texthora.Text = reader2["hora"].ToString();
                textmes.Text = reader2["mes"].ToString();
            }
            conexion.Close();
        }
    }
}
