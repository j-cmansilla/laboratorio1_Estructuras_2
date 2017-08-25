namespace Lab1
{
    public class Cancion
    {
        public string Titulo { get; set; }
        public Artista Artista { get; set; }
        public string Genero { get; set; }
        public string Duracion { get; set; }

        public Cancion()
        {

        }

        public Cancion(string nombre, Artista artista, string genero, string duracion)
        {
            this.Titulo = nombre;
            this.Artista = artista;
            this.Genero = genero;
            this.Duracion = duracion;
        }
    }
}