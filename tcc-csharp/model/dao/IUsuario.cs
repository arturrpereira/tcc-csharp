using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tcc_csharp.model.entities;

namespace tcc_csharp.model.dao
{
    public interface IUsuario
    {
        List<Usuario> findAll();
        void insert(Usuario obj);
        // void update();
        // void delete();
        Usuario findById(int idUsuario);

    }
}
