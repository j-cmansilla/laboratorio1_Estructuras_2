using System;

namespace Lab1
{
    public class Usuario
    {

        public Usuario(string nombre, Guid iD, string contrasenia, string nombreUsuario)
        {
            Nombre = nombre;
            ID = iD;
            Contrasenia = contrasenia;
            NombreUsuario = nombreUsuario;
        }

        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public Guid ID { get; set; }
        public string Contrasenia { get; set; }
    }
}