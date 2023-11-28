using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using partidaService.model.entities;

namespace partidaService.model.dao
{
    public interface IMovimentacoes
    {
        void insert(Movimentacao obj);
    }
}
