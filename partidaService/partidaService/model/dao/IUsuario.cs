using partidaService.model.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partidaService.model.dao
{
    public interface IUsuario
    {
        List<Usuario> findAll();
        void insert(Usuario obj);
        void update(Usuario obj);
        Usuario findById(int idUsuario);
        // void delete();
    }
}
