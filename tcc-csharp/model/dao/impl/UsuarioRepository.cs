using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tcc_csharp.model.entities;
using Npgsql;
using tcc_csharp.Data;
using tcc_csharp.Common.Extensions;

namespace tcc_csharp.model.dao.impl
{
    public class UsuarioRepository : IUsuario
    {
        private readonly IDatabase _database;
        public UsuarioRepository(IDatabase database)
        {
            _database = database;
            _database.Open();
        }

        public List<Usuario> findAll()
        {
            string sql = "SELECT * " +
                "FROM Usuarios";

            using (IDbCommand command = _database.CreateCommand(sql))
            {
                using (IDataReader reader = command.ExecuteReader())
                {
                    List<Usuario> list = new List<Usuario>();

                    while (reader.Read())
                    {
                        Usuario usuario = new Usuario();
                        usuario.id_usuario = reader.GetInt32("id_usuario");
                        usuario.nome = reader.GetString("nome");
                        usuario.email = reader.GetString("email");
                        usuario.login = reader.GetString("login");
                        usuario.senha = reader.GetString("senha");
                        usuario.username = reader.GetString("username");
                        usuario.saldo = reader.GetFloat("saldo");
                        usuario.dataNascimento = reader.GetDateTime("datanascimento");
                        usuario.perfilRiot.id = reader.GetString("idriot");
                        usuario.perfilRiot.accountId = reader.GetString("accountid");
                        usuario.perfilRiot.profileIconId = reader.GetInt32("profileiconid");
                        usuario.perfilRiot.summonerLevel = reader.GetInt32("summonerlevel");

                        list.Add(usuario);
                    }
                    return list;
                }
            }
        }
        public Usuario findById(int idUsuario)
        {
            string sql = "SELECT * " +
                "FROM usuarios WHERE id_usuario = @id_usuario";

            using (IDbCommand command = _database.CreateCommand(sql))
            {
                command.Parameters.Add(new NpgsqlParameter("@id_usuario", idUsuario));

                using (IDataReader reader = command.ExecuteReader())
                {
                    Usuario usuario = new Usuario();

                    while (reader.Read())
                    {
                        usuario.id_usuario = reader.GetInt32("id_usuario");
                        usuario.nome = reader.GetString("nome");
                        usuario.email = reader.GetString("email");
                        usuario.login = reader.GetString("login");
                        usuario.senha = reader.GetString("senha");
                        usuario.username = reader.GetString("username");
                        usuario.saldo = reader.GetFloat("saldo");
                        usuario.dataNascimento = reader.GetDateTime("datanascimento");
                    }

                    return usuario;
                }
            }
        }
        public void insert(Usuario obj)
        {
            string sql = "INSERT INTO usuarios ( " +
                "nome, " +
                "email, " +
                "login, " +
                "senha, " +
                "username, " +
                "saldo, " +
                "dataNascimento, " +
                "idRiot, " +
                "accountId, " +
                "profileIconId, " +
                "summonerLevel) " +
                "VALUES (" +
                "@nome, " +
                "@email, " +
                "@login, " +
                "@senha, " +
                "@username, " +
                "@saldo, " +
                "@dataNascimento, " +
                "@idRiot, " +
                "@accountId, " +
                "@profileIconId, " +
                "@summonerLevel)";

            using (IDbCommand command = _database.CreateCommand(sql))
            {
                command.Parameters.Add(new NpgsqlParameter("@nome", obj.nome));
                command.Parameters.Add(new NpgsqlParameter("@email", obj.email));
                command.Parameters.Add(new NpgsqlParameter("@login", obj.login));
                command.Parameters.Add(new NpgsqlParameter("@senha", obj.senha));
                command.Parameters.Add(new NpgsqlParameter("@username", obj.username));
                command.Parameters.Add(new NpgsqlParameter("@saldo", obj.saldo));
                command.Parameters.Add(new NpgsqlParameter("@dataNascimento", obj.dataNascimento));
                command.Parameters.Add(new NpgsqlParameter("@idRiot", obj.perfilRiot.id));
                command.Parameters.Add(new NpgsqlParameter("@accountId", obj.perfilRiot.accountId));
                command.Parameters.Add(new NpgsqlParameter("@profileIconId", obj.perfilRiot.profileIconId));
                command.Parameters.Add(new NpgsqlParameter("@summonerLevel", obj.perfilRiot.summonerLevel));

                command.ExecuteNonQuery();
            }
        }
    }
}
