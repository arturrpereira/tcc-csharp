using partidaService.model.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partidaService.model.dao
{
    public interface IFila
    {
        List<Fila> findAll();
        void deleteById(int userid);
    }
}
