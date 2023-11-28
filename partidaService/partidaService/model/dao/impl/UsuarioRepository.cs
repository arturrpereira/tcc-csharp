using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using tcc_csharp.Data;
using partidaService.Common.Extensions;
using partidaService.model.entities;
using partidaService.model.dao;

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

                command.ExecuteNonQuery();
            }
        }

        public void update(Usuario obj)
        {
            string sql = "UPDATE usuarios " +
                "SET saldo = @saldo " +
                "WHERE id_usuario = @id_usuario";

            using (IDbCommand command = _database.CreateCommand(sql))
            {
                command.Parameters.Add(new NpgsqlParameter("@id_usuario", obj.id_usuario));
                command.Parameters.Add(new NpgsqlParameter("@saldo", obj.saldo));

                command.ExecuteNonQuery();
            }

        }
    }
}
