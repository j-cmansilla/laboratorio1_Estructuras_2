using System.Collections.Generic;

namespace Lab1
{
    internal class PlayList
    {
        public PlayList(List<Cancion> playList, string usuarioID)
        {
            this.playList = playList;
            this.UsuarioID = usuarioID;
        }

        public List<Cancion> playList { get; set; }
        public string UsuarioID { get; set; }
    }
}