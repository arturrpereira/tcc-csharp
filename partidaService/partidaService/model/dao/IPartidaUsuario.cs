using partidaService.model.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partidaService.model.dao
{
    public interface IPartidaUsuario
    {
        List<PartidaUsuario> findByUsuario(Usuario usuario);

        void insert(PartidaUsuario obj);

        List<PartidaUsuario> findByPartida(Partida partida);
    }
}
