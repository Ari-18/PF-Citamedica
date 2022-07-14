using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome;

namespace PF_Citamedica
{
    public partial class WG_secre : Form
    {

        public WG_secre()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void iconButton1_Click(object sender, EventArgs e)
        {
            abrir_form(new PF_Citamedica.M_Citas());
        }
        
        private void iconButton2_Click(object sender, EventArgs e)
        {
            abrir_form(new PF_Citamedica.M_Doctor());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            abrir_form(new PF_Citamedica.M_Cosnsulta());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            abrir_form(new PF_Citamedica.M_Factura());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {

            abrir_form(new PF_Citamedica.M_Paciente());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            // aquí falta el enlace para usuario
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            //aqui falta el enlace para configuracion 
        }
        #region metodo para enlazar

        private Form vForm = null;

        private void abrir_form(Form pForm)
        {
            if (vForm != null)
            {
                vForm.Close();

            }
            vForm = pForm;
            pForm.TopLevel = false;
            pForm.FormBorderStyle = FormBorderStyle.None;
            pForm.Dock = DockStyle.Fill;
            panel_principal.Controls.Add(pForm);
            pForm.BringToFront();
            pForm.Show();
        }
        #endregion
    }
}
