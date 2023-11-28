﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tcc_csharp.Common.Extensions;
using tcc_csharp.Data;
using tcc_csharp.model.entities;

namespace tcc_csharp.model.dao.impl
{
    public class PartidaUsuarioRepository : IPartidaUsuario
    {
        private readonly IDatabase _database;

        public PartidaUsuarioRepository(IDatabase database)
        {
            _database = database;
            _database.Open();
        }

        public List<PartidaUsuario> findByPartida(int idPartida)
        {
            string sql = "SELECT * " +
                "FROM partida_usuario " +
                "INNER JOIN partidas " +
                "ON partida_usuario.fk_id_partida = partidas.id_partida " +
                "INNER JOIN usuarios " +
                "on partida_usuario.fk_id_usuario = usuarios.id_usuario " +
                "WHERE partida_usuario.fk_id_partida = @id_partida";

            using (IDbCommand command = _database.CreateCommand(sql))
            {
                command.Parameters.Add(new NpgsqlParameter("@id_partida", idPartida));

                using (IDataReader reader = command.ExecuteReader())
                {
                    List<PartidaUsuario> list = new List<PartidaUsuario>();

                    while (reader.Read())
                    {
                        PartidaUsuario partidaUsuario = new PartidaUsuario();
                        partidaUsuario.time = reader.GetInt32("time");
                        partidaUsuario.votoUsuario = reader.GetInt32("voto_usuario");
                        partidaUsuario.role = reader.GetString("role");

                        partidaUsuario.usuario.id_usuario = reader.GetInt32("id_usuario");
                        partidaUsuario.usuario.nome = reader.GetString("nome");
                        partidaUsuario.usuario.email = reader.GetString("email");
                        partidaUsuario.usuario.login = reader.GetString("login");
                        partidaUsuario.usuario.username = reader.GetString("username");
                        partidaUsuario.usuario.saldo = reader.GetFloat("saldo");
                        partidaUsuario.usuario.senha = reader.GetString("senha");
                        partidaUsuario.usuario.dataNascimento = reader.GetDateTime("dataNascimento");

                        list.Add(partidaUsuario);
                    }
                    return list;
                }
            }
        }

        public List<PartidaUsuario> findByUsuario(Usuario obj)
        {
            string sql = "SELECT * " +
                "FROM partida_usuario " +
                "INNER JOIN partidas " +
                "ON partida_usuario.fk_id_partida = partidas.id_partida " +
                "INNER JOIN usuarios " +
                "on partida_usuario.fk_id_usuario = usuarios.id_usuario " +
                "WHERE partida_usuario.fk_id_usuario = @id_usuario";

            using (IDbCommand command = _database.CreateCommand(sql))
            {
                command.Parameters.Add(new NpgsqlParameter("@id_usuario", obj.id_usuario));

                using (IDataReader reader = command.ExecuteReader())
                {
                    List<PartidaUsuario> list = new List<PartidaUsuario>();

                    while (reader.Read())
                    {
                        PartidaUsuario partidaUsuario = new PartidaUsuario();
                        partidaUsuario.time = reader.GetInt32("time");
                        partidaUsuario.votoUsuario = reader.GetInt32("voto_usuario");
                        partidaUsuario.role = reader.GetString("role");
                        partidaUsuario.partida.data = reader.GetDateTime("data");
                        partidaUsuario.partida.id_partida = reader.GetInt32("id_partida");
                        partidaUsuario.partida.valorApostado = reader.GetFloat("valor_apostado");
                        partidaUsuario.partida.timeVencedor = reader.GetInt32("time_vencedor");

                        partidaUsuario.usuario.id_usuario = reader.GetInt32("id_usuario");
                        partidaUsuario.usuario.nome = reader.GetString("nome");
                        partidaUsuario.usuario.email = reader.GetString("email");
                        partidaUsuario.usuario.login = reader.GetString("login");
                        partidaUsuario.usuario.username = reader.GetString("username");
                        partidaUsuario.usuario.saldo = reader.GetFloat("saldo");
                        partidaUsuario.usuario.senha = reader.GetString("senha");
                        partidaUsuario.usuario.dataNascimento = reader.GetDateTime("dataNascimento");

                        list.Add(partidaUsuario);
                    }
                    return list;
                }
            }
        }

        public void update(PartidaUsuario obj)
        {
            string sql = "UPDATE partida_usuario " +
                "SET voto_usuario = @voto_usuario " +
                "WHERE fk_id_partida = @fk_id_partida AND fk_id_usuario = @fk_id_usuario";

            using (IDbCommand command = _database.CreateCommand(sql))
            {
                command.Parameters.Add(new NpgsqlParameter("@voto_usuario", obj.votoUsuario));
                command.Parameters.Add(new NpgsqlParameter("@fk_id_partida", obj.partida.id_partida));
                command.Parameters.Add(new NpgsqlParameter("@fk_id_usuario", obj.usuario.id_usuario));

                command.ExecuteNonQuery();
            }
        }
    }
}
