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
    public partial class LOGUIN : Form
    {
        public LOGUIN()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void LOGUIN_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Usuario")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Usuario";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Contraseña")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.White;
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Contraseña";
                textBox2.ForeColor = Color.White;
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "admin")
            {
                this.DialogResult = DialogResult.OK;

                WG_menuPrincipal frm = new WG_menuPrincipal();
                frm.ShowDialog();

            }

            else if (textBox1.Text == "secretaria" && textBox2.Text == "secretaria")
            {

                WG_secre frm = new WG_secre();
                frm.ShowDialog();
               
            }

            else if (textBox1.Text == "paciente" && textBox2.Text == "paciente")
            {
                WG_menuPaciente frm = new WG_menuPaciente();
                frm.ShowDialog();
            }

            label1.Visible = true;
            this.DialogResult = DialogResult.None;

        }
    }
}
