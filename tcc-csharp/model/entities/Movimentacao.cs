using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tcc_csharp.model.entities
{
    public class Movimentacao
    {
        public int id_movimentacao {  get; set; }
        public float valor {  get; set; }
        public int tipooperacao { get; set; }
        public Usuario usuario { get; set;}
        public Partida Partida { get; set; }

        public Movimentacao() 
        { 
            this.usuario = new Usuario();   
            this.Partida = new Partida();   
        }   
    }
}
