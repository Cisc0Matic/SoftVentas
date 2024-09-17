using SoftVentas.Views.Form2Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftVentas.Views
{
    public partial class Form2 : Form
    {
        public Form2()
        {
          
            InitializeComponent();
            //panel3 = new Panel();
            ////panel3.Hide = true;
            //panel3.Visible = false;
        }
        private void abrirFormCli(object formhijo)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form fc = formhijo as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fc);
            this.panel3.Tag = fc;
            fc.Show();
        }
        private void cliBtn_Click(object sender, EventArgs e)
        {
            abrirFormCli(new FormCliente());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
