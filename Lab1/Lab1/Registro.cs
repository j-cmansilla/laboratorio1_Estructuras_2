using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Registro_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtNombreUsuario.Text == "" || txtContra.Text == "" || txtContraNueva.Text == "")
            {
                MessageBox.Show("Llene todos los campos!");
            }
            else
            {
                if (txtContra.Text!= txtContraNueva.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden!");
                }
                else
                {
                    if (ControlUsuarios.ReconocerUsuario(txtNombreUsuario.Text, txtContra.Text))
                    {
                        MessageBox.Show("Nombre de usuario en uso, escoja otro!");
                    }
                    else
                    {
                        ControlUsuarios.RegistrarUsuario(new Usuario(txtNombre.Text,Guid.NewGuid(), txtContra.Text,txtNombreUsuario.Text));
                        MessageBox.Show("Usuario correctamente creado! Ahora puede iniciar sesion!");
                        login l = new login();
                        l.Show();
                        this.Close();
                    }
                }
            }
        }
    }
}
