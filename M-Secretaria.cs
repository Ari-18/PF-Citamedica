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
    public partial class M_Secretaria : Form
    {
        public M_Secretaria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            M_Editar_Secretatia editarSecretatia = new M_Editar_Secretatia();
            editarSecretatia.ShowDialog();


        }
    }
}
