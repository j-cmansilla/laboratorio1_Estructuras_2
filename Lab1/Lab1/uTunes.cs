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
        private const string nombrePorDefectoRuta = @"C:/uTunes/Canciones/";
        private const string nombrePorDefectoArchivo = "canciones.csv";
        public static Usuario usuarioLogueado;
        public uTunes()
        {
            InitializeComponent();
            userMenu.Text = usuarioLogueado.Nombre;
            ControlCanciones.initialize();
            ControlCanciones.FillSongs(nombrePorDefectoArchivo);
            LlenarCanciones();
        }
        
        private void LlenarPlaylist()
        {
            vaciarDataGridPlaylist();
            for (int i = 0; i < ControlPlayList.listaCanciones.Count; i++)
            {
                dtPlaylist.Rows.Add();
                dtPlaylist.Rows[i].SetValues(ControlPlayList.listaCanciones.ElementAt(i).Titulo, ControlPlayList.listaCanciones.ElementAt(i).Artista, ControlPlayList.listaCanciones.ElementAt(i).Genero, ControlPlayList.listaCanciones.ElementAt(i).Duracion, ControlPlayList.listaCanciones.ElementAt(i).Localizacion);
            }
        }

        private void LlenarCanciones()
        {
            vaciarDataGrid();
            for (int i = 0; i < ControlCanciones.listaCanciones.Count; i++)
            {
                dtCanciones.Rows.Add();
                dtCanciones.Rows[i].SetValues(ControlCanciones.listaCanciones.ElementAt(i).Titulo, ControlCanciones.listaCanciones.ElementAt(i).Artista, ControlCanciones.listaCanciones.ElementAt(i).Genero, ControlCanciones.listaCanciones.ElementAt(i).Duracion, ControlCanciones.listaCanciones.ElementAt(i).Localizacion);
            }
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
            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtCancion_TextChanged(object sender, EventArgs e)
        {
            if (txtCancion.Text == "")
            {
                btnBuscar.Enabled = false;
            }
            else
            {
                btnBuscar.Enabled = true;
            }
        }

        public void vaciarDataGrid()
        {
            int count = dtCanciones.Rows.Count;
            for (int j = count; j > 0; j--)
            {
                dtCanciones.Rows.Remove(dtCanciones.Rows[j - 1]);
            }
        }

        public void vaciarDataGridPlaylist()
        {
            int count = dtPlaylist.Rows.Count;
            for (int j = count; j > 0; j--)
            {
                dtPlaylist.Rows.Remove(dtPlaylist.Rows[j - 1]);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            vaciarDataGrid();
            List<String> lista = ControlCanciones.buscarCanciones(txtCancion.Text);
            for (int i = 0; i < lista.Count; i++)
            {
                String[] datos = lista.ElementAt(i).Split(',');
                dtCanciones.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4]);
            }

            if (lista.Count == 0)
            {
                MessageBox.Show("Ningun dato coincide con el criterio de busqueda!");
            }
            else
            {
                MessageBox.Show("Busqueda finalizada, hay " + lista.Count + " coincidencias para " + txtCancion.Text);
            }
        }

        private void dtCanciones_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void playlistMenu_Click(object sender, EventArgs e)
        {

        }

        private void mostrarCanciones_Click(object sender, EventArgs e)
        {
            
        }

        private void mediaPlayer_EndOfStream(object sender, AxWMPLib._WMPOCXEvents_EndOfStreamEvent e)
        {
            
        }

        private void seleccionarCancionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void openDialog_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void txtPlaylist_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAgregarPlaylist_Click(object sender, EventArgs e)
        {
            Cancion cancion = ControlCanciones.buscarUrlCancion(dtCanciones.SelectedCells[0].Value.ToString());
            if (cancion == null)
            {
                MessageBox.Show("Debe seleccionar la casilla de titulo para esta operacion!");
            }
            else
            {
                ControlPlayList.AgregarCancion(cancion);
                MessageBox.Show("Cancion: " + (string)dtCanciones.SelectedCells[0].Value + " agregada a la playlist!");
            }
        }

        private void btnCrearPlaylist_Click(object sender, EventArgs e)
        {
           
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                vaciarDataGridPlaylist();
                ControlPlayList.FillSongs("playlist.csv");
                LlenarPlaylist();
            }
        }

        private void dtPlaylist_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            openDialog.Filter = "Canciones|*.mp3";
            openDialog.ShowDialog();
            if (!openDialog.FileName.Equals(""))
            {
                Cancion cancion = new Cancion();
                TagLib.File mp3 = TagLib.File.Create(openDialog.FileName);
                string nombreCancion = "";
                for (int i = openDialog.FileName.Length - 4; i > 0; i--)
                {
                    if (openDialog.FileName[i].ToString().Equals(@"\"))
                    {
                        i = 0;
                    }
                    else
                    {
                        nombreCancion = nombreCancion + openDialog.FileName[i].ToString();
                    }
                }
                string nuevoNombre = "";
                for (int i = nombreCancion.Length - 1; i > 0; i--)
                {
                    nuevoNombre = nuevoNombre + nombreCancion[i].ToString();
                }
                cancion.Titulo = nuevoNombre;
                cancion.Localizacion = openDialog.FileName;
                string segundos;
                if (mp3.Properties.Duration.Seconds<10)
                {
                    segundos = "0" + mp3.Properties.Duration.Seconds.ToString();
                }
                else
                {
                    segundos = mp3.Properties.Duration.Seconds.ToString();
                }
                cancion.Duracion = mp3.Properties.Duration.Minutes.ToString() + ":" + segundos;
                if (mp3.Tag.FirstPerformer == null)
                {
                    cancion.Artista = "Desconocido";
                }
                else
                {
                    cancion.Artista = mp3.Tag.FirstPerformer;
                }
                if (mp3.Tag.FirstGenre == null)
                {
                    cancion.Genero = "Desconocido";
                }
                else
                {
                    cancion.Genero = mp3.Tag.FirstGenre;
                }
                ControlCanciones.AgregarCancion(cancion);
                ControlCanciones.listaCanciones.Add(cancion);
                MessageBox.Show("Cancion: " + cancion.Titulo + " correctamente agregado!");
                ControlCanciones.FillSongs(nombrePorDefectoArchivo);
                LlenarCanciones();
            }
            openDialog.FileName = "";
        }

        private void rdbAs_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbAs_CheckedChanged(object sender, EventArgs e)
        {
            Ordenar();
        }

        private void rdbDes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Ordenar()
        {
            if (!rdbDes.Checked && !rdbAs.Checked)
            {

            }
            else
            {
                if (cmbOrdenar.SelectedIndex == 0)
                {
                    if (rdbAs.Checked)
                    {
                        ControlPlayList.OrdenarListaPorTitulo("as");
                    }
                    else
                    {
                        ControlPlayList.OrdenarListaPorTitulo("des");
                    }
                }
                else
                {
                    if (rdbDes.Checked)
                    {
                        ControlPlayList.OrdenarListaPorDuracion("des");
                    }
                    else
                    {
                        ControlPlayList.OrdenarListaPorDuracion("as");
                    }
                }
            }
            LlenarPlaylist();
        }

        private void cmbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ordenar();
        }

        private void dtCanciones_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cancion cancion = ControlCanciones.buscarUrlCancion(dtCanciones.SelectedCells[0].Value.ToString());
            if (cancion != null)
            {
                mediaP.URL = cancion.Localizacion;
                nowPlaying.Text = "Ahora suena: " + cancion.Titulo + "-" + cancion.Artista;
            }
            else
            {
                MessageBox.Show("Debe seleccionar la casilla de titulo para esta operacion!");
            }
        }

        private void dtCanciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAgregarPlaylist.Enabled = true;
        }

        private void dtPlaylist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cancion cancion = ControlPlayList.buscarUrlCancion(dtPlaylist.SelectedCells[0].Value.ToString());
            if (cancion == null)
            {
                MessageBox.Show("Debe seleccionar la casilla de titulo para esta operacion!");
            }
            else
            {
                mediaP.URL = cancion.Localizacion;
                nowPlaying.Text = "Ahora suena: " + cancion.Titulo + "-" + cancion.Artista;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LlenarCanciones();
            pictureBox1.Visible = false;
        }
    }
}
