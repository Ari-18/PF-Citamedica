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
    public partial class Wan_Paciente : Form
    {
        public Wan_Paciente()
        {
            InitializeComponent();
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
            Wan_EditarPaciente editarPaciente = new Wan_EditarPaciente();
            editarPaciente.ShowDialog();
        }
    }
}
