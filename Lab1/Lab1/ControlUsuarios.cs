using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class ControlUsuarios
    {
        private const string nombrePorDefectoRuta = @"C:/uTunes/Usuarios/";
        private const string nombrePorDefectoArchivo = "usuarios.csv";
        public static bool DictionaryIsLoaded = false;
        public static void initialize()
        {
            if (!Directory.Exists(nombrePorDefectoRuta+nombrePorDefectoArchivo))
            {
                Directory.CreateDirectory(nombrePorDefectoRuta);
            }
            else
            {
                Users.Add("admin", "admin");
                List<string> Lines = new List<string>();
                if (!Directory.Exists(nombrePorDefectoRuta))
                {
                    Directory.CreateDirectory(nombrePorDefectoRuta);
                }
                File.WriteAllLines(nombrePorDefectoRuta + nombrePorDefectoArchivo, Lines.ToArray());
                FillUsers(nombrePorDefectoRuta + nombrePorDefectoArchivo);
            }

        }

        public static String[] agregarUsuarios(Usuario usuario)
        {
            String[] datos = new String[1];
            datos[0] = usuario.NombreUsuario+","+usuario.Contrasenia+","+usuario.ID+","+usuario.Nombre;
            return datos;
        }
        public static void RegistrarUsuario(Usuario usuario)
        {
            if (!File.Exists(nombrePorDefectoRuta + nombrePorDefectoArchivo))
            {
                initialize();
                File.WriteAllLines(nombrePorDefectoRuta + nombrePorDefectoArchivo, agregarUsuarios(usuario));
            }
            else
            {
                String[] datosDeVuelta = File.ReadAllLines(nombrePorDefectoRuta + nombrePorDefectoArchivo);
                String[] nuevosDatos = new String[datosDeVuelta.Length + 1];
                for (int i = 0; i < nuevosDatos.Length; i++)
                {
                    if (i == datosDeVuelta.Length)
                    {
                        nuevosDatos[i] = agregarUsuarios(usuario)[0];
                    }
                    else
                    {
                        nuevosDatos[i] = datosDeVuelta[i];
                    }
                }
                File.WriteAllLines(nombrePorDefectoRuta + nombrePorDefectoArchivo, nuevosDatos);
            }
        }
        
        public static String[] listaUsuarios;

        public static Usuario RetornarUsuarioLogueado(string nombreUsuario)
        {
            for (int i = 0; i < listaUsuarios.Length; i++)
            {
                string[] datos = listaUsuarios[i].Split(',');
                if (datos[0] == nombreUsuario)
                {
                    return new Usuario(datos[3],new Guid(datos[2]),datos[1], datos[0]);
                }
            }
            return new Usuario("", Guid.NewGuid(), "", "");
        }

        public static bool ReconocerUsuario(string nombreUsuario, string pass)
        {
                for (int i = 0; i < Users.Count; i++)
                {
                    if (Users.ElementAt(i).Value.Equals(pass) && Users.ElementAt(i).Key.Equals(nombreUsuario))
                    {
                        return true;
                    }
                }
            return false;
        }

        public static Dictionary<string,string> Users = new Dictionary<string, string>();

        public static void FillUsers(string FilePath)
        {
            Users = new Dictionary<string, string>();
            string[] Lines = ControlDeArchivos.OpenFile(FilePath);
            listaUsuarios = Lines;
            foreach (string Line in Lines)
            {
                string[] SeparatedValues = Line.Split(',');
                string Key = SeparatedValues[0];
                string Value = SeparatedValues[1];
                Users.Add(Key, Value);
            }
            if (!Directory.Exists(nombrePorDefectoRuta))
            {
                Directory.CreateDirectory(nombrePorDefectoRuta);
            }
            File.WriteAllLines(nombrePorDefectoRuta + nombrePorDefectoArchivo, Lines);

            DictionaryIsLoaded = true;
        }
    }
}
