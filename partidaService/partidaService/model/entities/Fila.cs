using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partidaService.model.entities
{
    public class Fila
    {
        public float valorSugerido { get; set; }
        public string role { get; set; }
        public Usuario usuario { get; set; }   

        public Fila()
        {
            usuario = new Usuario();
        }
    }
}
