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
    public partial class A_Factura : Form
    {
        public A_Factura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A_addFactura AgregarFactuADM = new A_addFactura();
            AgregarFactuADM.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            A_EditarFact EditFactADM = new A_EditarFact();
            EditFactADM.ShowDialog();
        }
    }
}
