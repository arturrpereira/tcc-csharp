using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using tcc_csharp.model.dao.impl;
using tcc_csharp.model.entities;
using System.Windows.Forms;
using Npgsql.PostgresTypes;
using tcc_csharp.Data;

namespace tcc_csharp.validators
{
    public class UsuarioValidator
    {
        private static readonly UsuarioRepository _usuarioRepository = new UsuarioRepository(new Postgre());
        public static bool ValidateUsername(string username)
        {
            foreach(Usuario usuario in _usuarioRepository.findAll())
            {
                if(usuario.username == username)
                {
                    return false;
                }

            }

            return true;
        }

        public static bool ValidLogin(string login)
        {
            foreach(Usuario usuario in _usuarioRepository.findAll())
            {
                if(usuario.login == login)
                {
                    return false;
                }

            }
            return true;
        }

        public static bool verificaSeJaExiste(Usuario user)
        {

            List<Usuario> usuarios = _usuarioRepository.findAll();

            foreach(Usuario usuario in usuarios) {
                if (usuario.login == user.login)
                {
                    return false;
                }
            }
            return true;
        }
        public bool UsuarioExiste(Usuario usuario)
        {
            try
            {
                List <Usuario> usuarios = _usuarioRepository.findAll();
                return true;
            }
            catch(Exception e)
            {
                return true;
            }
        }
    }
}
