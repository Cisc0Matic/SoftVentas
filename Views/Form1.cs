using SoftVentas.Repositories;
using SoftVentas.Views;
using System;
using System.Windows.Forms;

namespace SoftVentas
{
    public partial class Form1 : Form
    {
        private UsuarioRepositorio repositorio;

        public Form1()
        {
            InitializeComponent();
            repositorio = new UsuarioRepositorio(); // Inicializa el repositorio
            lblUser.Visible = false; // Inicialmente ocultar controles
            txtUser.Visible = false;
            textBox2.UseSystemPasswordChar = true; // Ocultar texto de contraseña
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Mostrar campos de usuario y contraseña
            lblUser.Visible = true;
            txtUser.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
            //btnLogin.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Crear un nuevo usuario con los datos del formulario
            Usuario nuevoUsuario = new Usuario
            {
                NombreUsuario = txtUser.Text,
                Password = textBox2.Text,
                Email = textBox1.Text
            };

            // Llamar al método RegistrarUsuario del repositorio
            bool registroExitoso = repositorio.RegistrarUsuario(nuevoUsuario);

            if (registroExitoso = true)
            {
                MessageBox.Show("Usuario registrado exitosamente!");
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario.");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Crear un usuario con los datos del formulario para autenticación
            Usuario usuario = new Usuario
            {
                NombreUsuario = txtUser.Text,
                Password = textBox2.Text
            };

            // Llamar al método AutenticarUsuario del repositorio
            bool autenticado = repositorio.AutenticarUsuario(usuario);

            if (autenticado)
            {
                MessageBox.Show("Login exitoso!");
                // Navegar a otro formulario si es necesario
                // Form2 f2 = new Form2();
                // f2.Visible = true;
                // this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
        }

        // Otros métodos del formulario pueden permanecer igual
        private void label1_Click(object sender, EventArgs e)
        {
            // Código existente
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Código existente
        }

        private void log(object sender, MouseEventArgs e)
        {
            // Crear un usuario con los datos del formulario para autenticación
            Usuario usuario = new Usuario
            {
                NombreUsuario = txtUser.Text,
                Password = textBox2.Text
            };

            // Llamar al método AutenticarUsuario del repositorio
            bool autenticado = repositorio.AutenticarUsuario(usuario);

            if (autenticado)
            {
                MessageBox.Show("Login exitoso!");
                Form2 f2 = new Form2();
                f2.Visible = true;
                if (f2.Visible)
                {
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
            // Código existente para abrir Form2
        
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            // Código existente
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Código existente
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void isClicked(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void txtB2_isClicked(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
    }
}
