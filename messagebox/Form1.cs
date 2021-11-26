using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messagebox
{

    public partial class Form1 : Form
    {
        usuario usuario = new usuario();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (txtusuario.Text == usuario.uusuario && txtcontraseña.Text == usuario.cotraseña)
            {

                MessageBox.Show("¡¡Bienvenido!!");

            }

            if (txtusuario.Text != usuario.uusuario && txtcontraseña.Text == usuario.cotraseña)
            {

                MessageBox.Show("El usuario es incorrecto. ");

            }

            if (txtusuario.Text == usuario.uusuario && txtcontraseña.Text != usuario.cotraseña)
            {

                MessageBox.Show("La contraseña es incorrecta. ");

            }

            if (txtusuario.Text != usuario.uusuario && txtcontraseña.Text != usuario.cotraseña)
            {

                MessageBox.Show("El usuario y la contraseña son incorrectos.");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            usuario.uusuario = "juan";
            usuario.cotraseña= "123";
        }
    }

    class usuario
    {

        public string uusuario;
        public string cotraseña;

    }
}
