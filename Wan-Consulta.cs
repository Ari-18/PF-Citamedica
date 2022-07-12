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
    public partial class Wan_Consulta : Form
    {
        public Wan_Consulta()
        {
            InitializeComponent();
        }

        private void Wan_Consulta_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wan_AgregarConsulta AgregarConsulta = new Wan_AgregarConsulta();
            AgregarConsulta.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wan_EditarConsulta EditarConsulta = new Wan_EditarConsulta();
            EditarConsulta.ShowDialog();
        }
    }
}
