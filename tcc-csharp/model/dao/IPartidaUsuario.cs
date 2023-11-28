using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tcc_csharp.model.entities;

namespace tcc_csharp.model.dao
{
    public interface IPartidaUsuario
    {
        List<PartidaUsuario> findByUsuario(Usuario usuario);
        void update(PartidaUsuario obj);

        List<PartidaUsuario> findByPartida(int idPartida);
    }
}
