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
    public partial class uTunes : Form
    {
        public static Usuario usuarioLogueado;
        public uTunes()
        {
            InitializeComponent();
            userMenu.Text = usuarioLogueado.Nombre;
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Close();
        }

        private void playlists_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void playlists_Click(object sender, EventArgs e)
        {
            if (playlists.SelectedText == "")
            {
                MessageBox.Show("Para crear una ve a Playlists->Crear", "Playlists vacias :(");
            }
        }
    }
}
