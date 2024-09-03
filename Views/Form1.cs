using SoftVentas.Views;
using System;
using System.Windows.Forms;

namespace SoftVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void log(object sender, MouseEventArgs e)
        {
            // Crea una instancia de Form2
            Form2 f2 = new Form2();
            f2.Visible = true;
            if (f2.Visible)
            {
                this.Hide();
            }
        }
    }
}