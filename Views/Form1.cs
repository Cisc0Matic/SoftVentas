using SoftVentas.Repositories;
using SoftVentas.Views;
using System;
using System.Windows.Forms;

namespace SoftVentas
{
    public partial class Form1 : Form
    {
        bool isClickedOnce = false;
        bool isClickedOnce2 = false;

        // Repositorio alternativo que trabaja con una lista en memoria
        public UsuarioRepositorio repositorio;

        public Form1()
        {
            InitializeComponent();
            repositorio = new UsuarioRepositorio();
            // Inicializamos el repositorio en memoria
            repositorio.UsuarioRepositorioAlternativo();
            repositorio.mostrarListaUsuarios();
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            // Inicialmente ocultar controles
            lblUser.Visible = false;
            txtUser.Visible = false;
            textBox1.Visible = true; 
            textBox2.Visible = true; 
            button1.Visible = true; 
            button2.Visible = false; 
            textBox2.UseSystemPasswordChar = true; 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hacer visible algunos componentes para el registro
            lblUser.Visible = true;
            txtUser.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = false; 
            button2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  repositorio.mostrarListaUsuarios();
            // Manejo del inicio de sesión
            string email = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            // Usamos el repositorio alternativo en memoria para autenticar al usuario
            bool autenticado = repositorio.AutenticarUsuario(email, password);

            if (autenticado)
            {
                MessageBox.Show("Login exitoso!");
                Form2 f2 = new Form2();
                f2.Visible = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }

            // Lógica de autenticación con base de datos comentada
            /*
            bool autenticado = repositorio.AutenticarUsuario(email, password);

            if (autenticado)
            {
                MessageBox.Show("Login exitoso!");
                Form2 f2 = new Form2();
                f2.Visible = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
            */
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Obtén los datos ingresados
            string nombreUsuario = txtUser.Text.Trim();
            string password = textBox2.Text.Trim();
            string email = textBox1.Text.Trim();

            // Validaciones de los datos
            if (string.IsNullOrEmpty(nombreUsuario))
            {
                MessageBox.Show("Ingrese un nombre de usuario válido.");
                return;
            }
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Ingrese una contraseña válida.");
                return;
            }

            // Usamos el repositorio alternativo en memoria para registrar el usuario
            bool registroExitoso = repositorio.RegistrarUsuario1(nombreUsuario, password, email);

            if (registroExitoso)
            {
                MessageBox.Show("Usuario registrado exitosamente!");
                // Opcional: Ocultar campos después del registro
                lblUser.Visible = false;
                txtUser.Visible = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button1.Visible = true; // Volver a mostrar el botón de inicio de sesión
                button2.Visible = false; // Ocultar el botón de registro
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario.");
            }

            // Lógica de registro con base de datos comentada
            /*
            bool registroExitoso = repositorio.RegistrarUsuario(nombreUsuario, password, email);

            if (registroExitoso)
            {
                MessageBox.Show("Usuario registrado exitosamente!");
                // Opcional: Ocultar campos después del registro
                lblUser.Visible = false;
                txtUser.Visible = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button1.Visible = true; // Volver a mostrar el botón de inicio de sesión
                button2.Visible = false; // Ocultar el botón de registro
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario.");
            }
            */
        }

        private void isClicked1(object sender, EventArgs e)
        {
            if (!isClickedOnce)
            {
                textBox1.Text = string.Empty;
                isClickedOnce = true;
            }
        }

        private void isClicked2(object sender, EventArgs e)
        {
            if (!isClickedOnce2)
            {
                textBox2.Text = string.Empty;
                isClickedOnce = true;
            }
        }
    }
}
