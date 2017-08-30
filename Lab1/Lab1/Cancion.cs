namespace Lab1
{
    public class Cancion
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public string Genero { get; set; }
        public string Duracion { get; set; }
        public string Localizacion {get;set;}
        public Cancion()
        {

        }
        
        public Cancion(string titulo, string artista, string genero, string duracion, string localizacion)
        {
            Titulo = titulo;
            Artista = artista;
            Genero = genero;
            Duracion = duracion;
            Localizacion = localizacion;
        }
    }
}