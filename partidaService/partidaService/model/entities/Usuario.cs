using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partidaService.model.entities
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string login { get; set; }
        public string username { get; set; }
        public float saldo { get; set; }
        public string senha { get; set; }
        public DateTime dataNascimento { get; set; }

        public Usuario() 
        {
        }   
        public Usuario(string nome, string email, string login, string senha, DateTime dataNascimento)
        {
            this.nome = nome;
            this.email = email;
            this.login = login;
            this.senha = senha;
            this.dataNascimento = dataNascimento;
        }
    }
}
