using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcc_csharp.model.entities
{
    public class PartidaUsuario
    {
        public int time { get; set; }
        public string role { get; set; }
        public int votoUsuario { get; set; }
        public Partida partida { get; set; }
        public Usuario usuario { get; set; }

        public PartidaUsuario() 
        {
            partida = new Partida();
            usuario = new Usuario();
        }
    }
}
