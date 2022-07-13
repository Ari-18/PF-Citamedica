namespace PF_Citamedica
{
    public partial class AForm1 : Form
    {
        public AForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 AgregarDoctor = new Form3();
            AgregarDoctor.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 EditarDoctor = new Form2();
            EditarDoctor.ShowDialog();
        }
    }
}