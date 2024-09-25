using SoftVentas.Repositories;
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
        private ClienteRepositorio repositorio;
        public FormCliente()
        {
            InitializeComponent();
            repositorio = new ClienteRepositorio();


        }
        // Metodo para listar los clientes de la BD en el DataGrid
        private void CargarClientesEnLista()
        {
            // Obtener la lista de clientes del repositorio
            List<Cliente> listaClientes = repositorio.ObtenerClientes();

            // Asignar la lista como fuente de datos del DataGridView
            dataGridView1.DataSource = null; // Desvincula la lista anterior (si existía)
            dataGridView1.DataSource = listaClientes; // Reasigna la nueva lista
            dataGridView1.Refresh(); // Forzar el refresco del DataGridView
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ventas_softDataSet1.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.ventas_softDataSet1.cliente);

        }
        //eEvento del boton "agregar", cuando se apriete se guarda la info y se imprime el resultado en la lista
        private void button1_Click(object sender, EventArgs e)
        {
            // Obtén los datos ingresados
            string nombreCliente = textBox1.Text.Trim();
            string telefono1 = textBox2.Text.Trim(); 
            string telefono2 = textBox4.Text.Trim(); 
            string email = textBox3.Text.Trim();

            // Validaciones de los datos
            if (string.IsNullOrEmpty(nombreCliente))
            {
                MessageBox.Show("Ingrese un nombre válido.");
                return;
            }
            // Validación para los teléfonos (se verifica si están vacíos en lugar de convertir a int)
            if (string.IsNullOrEmpty(telefono1))
            {
                MessageBox.Show("Ingrese un número de teléfono 1 válido.");
                return;
            }

            if (string.IsNullOrEmpty(telefono2))
            {
                MessageBox.Show("Ingrese un número de teléfono 2 válido.");
                return;
            }

            //// Conversion de los teléfonos a int y validaciones
            //if (!int.TryParse(telefono1String, out int telefono1) || telefono1 <= 0)
            //{
            //    MessageBox.Show("Ingrese un número de teléfono 1 válido.");
            //    return;
            //}

            //if (!int.TryParse(telefono2String, out int telefono2) || telefono2 <= 0)
            //{
            //    MessageBox.Show("Ingrese un número de teléfono 2 válido.");
            //    return;
            //}

            //// Validacion para el correo electrónico
            //if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            //{
            //    MessageBox.Show("Ingrese un correo electrónico válido.");
            //    return;
            //}

            // El método registroExitoso espera 2 int para tel1 y tel2, porque así lo hice en la BD
            bool registroExitoso = repositorio.AgregarCliente(nombreCliente, telefono1, telefono2, email);

            repositorio.MostrarClientes();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarClientesEnLista();
            //dataGridView1.Refresh(); 
        }
    }
}
