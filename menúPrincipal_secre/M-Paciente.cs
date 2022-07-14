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
    public partial class M_Paciente : Form
    {
        public M_Paciente()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            M_AgregarPaciente agregarPaciente = new M_AgregarPaciente();
            agregarPaciente.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            M_EditarPaciente editarPaciente = new M_EditarPaciente();
            editarPaciente.ShowDialog();


        }
    }
}
