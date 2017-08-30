using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class ControlCanciones
    {
        public static List<Cancion> listaCanciones;
        
        private const string nombrePorDefectoRuta = @"C:/uTunes/Canciones/";
        private const string nombrePorDefectoArchivo = "canciones.csv";
        public static bool DictionaryIsLoaded = false;
        public static void initialize()
        {
            if (!Directory.Exists(nombrePorDefectoRuta + nombrePorDefectoArchivo))
            {
                Directory.CreateDirectory(nombrePorDefectoRuta);
            }
        }

        public static List<String> buscarCanciones(String criterioDeBusqueda)
        {
            List<String> listaDeCanciones = new List<String>();
            String[] datos = File.ReadAllLines(nombrePorDefectoRuta + nombrePorDefectoArchivo);
            for (int i = 0; i < datos.Length; i++)
            {
                String[] words = datos[i].Split(',');
                if (criterioDeBusqueda == words[0])
                {
                    listaDeCanciones.Add(words[0]+","+words[1]+","+words[2]+","+words[3]+","+words[4]);
                }
            }
            return listaDeCanciones;
        }

        public static String[] agregarCanciones(Cancion cancion)
        {
            String[] datos = new String[1];
            datos[0] = cancion.Titulo + "," + cancion.Artista + "," + cancion.Genero + "," + cancion.Duracion + "," + cancion.Localizacion;
            return datos;
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

        public static void FillSongs(string FilePath)
        {
            string[] Lines = ControlDeArchivos.OpenFile(FilePath);
            listaCanciones = new List<Cancion>();
            foreach (string Line in Lines)
            {
                string[] SeparatedValues = Line.Split(',');
                listaCanciones.Add(new Cancion(SeparatedValues[0],SeparatedValues[1],SeparatedValues[2],SeparatedValues[3],SeparatedValues[4]));
            }
            if (!Directory.Exists(nombrePorDefectoRuta))
            {
                Directory.CreateDirectory(nombrePorDefectoRuta);
            }
            File.WriteAllLines(nombrePorDefectoRuta + nombrePorDefectoArchivo, Lines);

            //DictionaryIsLoaded = true;
        }

    }
}
