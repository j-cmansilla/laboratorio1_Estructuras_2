namespace Lab1
{
    public class Artista
    {
        public string Nombre { get; set; }
        public string Pais { get; set; }

        public Artista()
        {
        }

        public Artista(string nombre, string pais)
        {
            Nombre = nombre;
            Pais = pais;
        }
    }
}