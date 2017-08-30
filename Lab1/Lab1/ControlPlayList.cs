using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class ControlPlayList
    {
        private const string nombrePorDefectoArchivo = "playlist.csv";
        public static bool DictionaryIsLoaded = false;
       
        public static List<Cancion> listaCanciones = new List<Cancion>();

        public static void FillSongs(string FilePath)
        {
            string[] Lines = ControlDeArchivos.OpenFile(FilePath);
            listaCanciones = new List<Cancion>();
            foreach (string Line in Lines)
            {
                string[] SeparatedValues = Line.Split(',');
                listaCanciones.Add(new Cancion(SeparatedValues[0], SeparatedValues[1], SeparatedValues[2], SeparatedValues[3], SeparatedValues[4])); 
            }
            if (!Directory.Exists(nombrePorDefectoArchivo))
            {
                //Directory.CreateDirectory(nombrePorDefectoArchivo);
            }
            File.WriteAllLines(nombrePorDefectoArchivo, Lines);
        }

        public static String[] agregarCanciones(Cancion cancion)
        {
            String[] datos = new String[1];
            datos[0] = cancion.Titulo + "," + cancion.Artista + "," + cancion.Genero + "," + cancion.Duracion+","+cancion.Localizacion;
            return datos;
        }

        public static void OrdenarListaPorDuracion(string forma)
        {
            if (forma == "des")
            {
                IEnumerable<Cancion> listaOrdenada = listaCanciones.OrderByDescending(Cancion => Cancion.Duracion);
                listaCanciones = listaOrdenada.ToList<Cancion>();
            }
            else
            {
                IEnumerable<Cancion> listaOrdenada = listaCanciones.OrderBy(Cancion => Cancion.Duracion);
                listaCanciones = listaOrdenada.ToList<Cancion>();
            }
        }

        public static void OrdenarListaPorTitulo(string forma)
        {
            if (forma == "des")
            {
                IEnumerable<Cancion> listaOrdenada = listaCanciones.OrderByDescending(Cancion => Cancion.Titulo);
                listaCanciones = listaOrdenada.ToList<Cancion>();
            }
            else
            {
                IEnumerable<Cancion> listaOrdenada = listaCanciones.OrderBy(Cancion => Cancion.Titulo);
                listaCanciones = listaOrdenada.ToList<Cancion>(); 
            }
        }

        public static void AgregarCancion(Cancion cancion)
        {
            if (!File.Exists(nombrePorDefectoArchivo))
            {
                File.WriteAllLines(nombrePorDefectoArchivo, agregarCanciones(cancion));
            }
            else
            {
                String[] datosDeVuelta = File.ReadAllLines(nombrePorDefectoArchivo);
                String[] nuevosDatos = new String[datosDeVuelta.Length + 1];
                for (int i = 0; i < nuevosDatos.Length; i++)
                {
                    if (i == datosDeVuelta.Length)
                    {
                        nuevosDatos[i] = agregarCanciones(cancion)[0];
                    }
                    else
                    {
                        nuevosDatos[i] = datosDeVuelta[i];
                    }
                }
                File.WriteAllLines(nombrePorDefectoArchivo, nuevosDatos);
            }
        }
        
        public static bool PlaylistExiste()
        {
            return File.Exists(nombrePorDefectoArchivo);
        }
        
    }
}
