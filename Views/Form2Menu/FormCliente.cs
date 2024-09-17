using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftVentas.Views.Form2Menu
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ventas_softDataSet1.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.ventas_softDataSet1.cliente);

        }
    }
}
