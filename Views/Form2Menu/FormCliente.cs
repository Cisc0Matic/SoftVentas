﻿using SoftVentas.Repositories;
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

        private void CargarClientesEnLista()
        {
            // Obtener la lista de clientes del repositorio
            List<Cliente> listaClientes = repositorio.ObtenerCliente();

            // Asignar la lista como fuente de datos del DataGridView
            dataGridView1.DataSource = listaClientes;
        }
        private void FormCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ventas_softDataSet1.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.ventas_softDataSet1.cliente);

        }
        //evento del boton "agregar", cuando se apriete se guarda la info y se imprime el resultado en la lista
        private void button1_Click(object sender, EventArgs e)
        {
            // Obtén los datos ingresados
            string nombreCliente = textBox1.Text.Trim();
            string telefono1String = textBox2.Text.Trim(); // Obtener texto del segundo TextBox
            string telefono2String = textBox4.Text.Trim(); // Obtener texto del cuarto TextBox
            string email = textBox3.Text.Trim();

            // Validaciones de los datos
            if (string.IsNullOrEmpty(nombreCliente))
            {
                MessageBox.Show("Ingrese un nombre válido.");
                return;
            }

            // Conversión de los teléfonos a int y validaciones
            if (!int.TryParse(telefono1String, out int telefono1) || telefono1 <= 0)
            {
                MessageBox.Show("Ingrese un número de teléfono 1 válido.");
                return;
            }

            if (!int.TryParse(telefono2String, out int telefono2) || telefono2 <= 0)
            {
                MessageBox.Show("Ingrese un número de teléfono 2 válido.");
                return;
            }

            // Validación para el correo electrónico
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.");
                return;
            }

            // El método registroExitoso espera 2 int para tel1 y tel2, porque así lo hice en la BD
            bool registroExitoso = repositorio.AgregarCliente(nombreCliente, telefono1, telefono2, email);

            repositorio.MostrarClientes();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarClientesEnLista();
        }
    }
}
