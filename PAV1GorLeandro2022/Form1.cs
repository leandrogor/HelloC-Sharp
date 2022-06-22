using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV1GorLeandro2022
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (box_usuario.Text.Equals("")|| box_contrasenia.Text.Equals(""))
            {
                MessageBox.Show("Por favor, introduzca todos los datos!");
            }
            else
            {
                string nombre = box_usuario.Text;
                string contrasenia = box_contrasenia.Text;

                MessageBox.Show("¡Bienvenido " + nombre + "!\n" +
                    "Su contraseña \"" + contrasenia + "\" es correcta.");
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El usuario es su nick o mail, \n" +
                "su contraseña si es primera vez es 0000.");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/leandrogabrielgor/");
        }
    }
}
