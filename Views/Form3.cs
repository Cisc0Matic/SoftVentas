using System;
using System.Drawing;
using System.Windows.Forms;

namespace SoftVentas.Views
{
    public partial class Form3 : Form
    {
        // Velocidad de movimiento en píxeles
        private int _movementSpeed = 10;

        public Form3()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form3_KeyDown);
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            // Obtén la posición actual del Label
            Point currentPosition = label1.Location;

            // Mueve el Label basado en la tecla presionada
            switch (e.KeyCode)
            {
                case Keys.W: // Mueve hacia arriba
                    label1.Location = new Point(currentPosition.X, currentPosition.Y - _movementSpeed);
                    break;
                case Keys.S: // Mueve hacia abajo
                    label1.Location = new Point(currentPosition.X, currentPosition.Y + _movementSpeed);
                    break;
                case Keys.A: // Mueve hacia la izquierda
                    label1.Location = new Point(currentPosition.X - _movementSpeed, currentPosition.Y);
                    break;
                case Keys.D: // Mueve hacia la derecha
                    label1.Location = new Point(currentPosition.X + _movementSpeed, currentPosition.Y);
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
