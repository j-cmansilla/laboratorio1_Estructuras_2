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
    public partial class login : Form
    {
        private const string nombrePorDefectoRuta = @"C:/uTunes/Usuarios/";
        private const string nombrePorDefectoArchivo = "usuarios.csv";
        public login()
        {
            ControlUsuarios.initialize();
            ControlUsuarios.FillUsers(nombrePorDefectoRuta+nombrePorDefectoArchivo);
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void refreshData()
        {
            txtUsuario.Text = "";
            txtPass.Text = "";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "" && txtUsuario.Text == "")
            {
                MessageBox.Show("Es necesario que llene ambos campos!");
            }
            else
            {
                if (ControlUsuarios.ReconocerUsuario(txtUsuario.Text,txtPass.Text))
                {
                    Usuario usuarioLogueado = ControlUsuarios.RetornarUsuarioLogueado(txtUsuario.Text);
                    refreshData();
                    MessageBox.Show("Usuario y contraseña validos.");
                    uTunes.usuarioLogueado = usuarioLogueado;
                    uTunes u = new uTunes();
                    u.Show();
                    this.Hide();
                }
                else
                {
                    refreshData();
                    MessageBox.Show("Usuario o contraseña invalidos.");
                }
            }
        }

        private void btn_Registro_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            r.Show();
            this.Hide();
        }
    }
}
