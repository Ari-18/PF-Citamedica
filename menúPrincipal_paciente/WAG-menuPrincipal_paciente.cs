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
    public partial class WG_menuPaciente : Form
    {

        public WG_menuPaciente()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void iconButton1_Click(object sender, EventArgs e)
        {
            abrir_form(new PF_Citamedica.Wan_Cita());
        }
        
        private void iconButton2_Click(object sender, EventArgs e)
        {
            abrir_form(new PF_Citamedica.WG_doctor());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            abrir_form(new PF_Citamedica.WAG_consulta());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            abrir_form(new PF_Citamedica.WAG_factura_paciente());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {

            // el de paciente
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            abrir_form(new PF_Citamedica.WAG_usuario_paciente());
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
