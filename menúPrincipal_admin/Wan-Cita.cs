using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF_Citamedica
{
    public partial class Wan_Cita : Form
    {
        
        public Wan_Cita()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Wan_Cita_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PF_Citamedica.EditarCita NuevaInstancia = new PF_Citamedica.EditarCita();
            NuevaInstancia.ShowDialog();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PF_Citamedica.W_AddCita AgregarCita = new PF_Citamedica.W_AddCita();
            AgregarCita.ShowDialog();
        }
    }
}
