using Npgsql;
using partidaService.Common.Extensions;
using partidaService.model.entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tcc_csharp.Data;

namespace partidaService.model.dao.impl
{
    public class PartidaRepository : IPartida
    {
        private readonly IDatabase _database;

        public PartidaRepository(IDatabase database)
        {
            _database = database;
            _database.Open();
        }

        public List<Partida> findAll()
        {
            string sql = "SELECT * " +
                "FROM partidas ";

            using (IDbCommand command = _database.CreateCommand(sql))
            {
                using (IDataReader reader = command.ExecuteReader())
                {
                    List<Partida> list = new List<Partida>();

                    while (reader.Read())
                    {
                        Partida partida = new Partida();
                        partida.id_partida = reader.GetInt32("id_partida");
                        partida.data = reader.GetDateTime("data");
                        partida.timeVencedor = reader.GetInt32("time_vencedor");
                        partida.valorApostado = reader.GetFloat("valor_apostado");

                        list.Add(partida);
                    }
                    return list;
                }
            }
        }

        public int insert(Partida obj)
        {
            string sql = "INSERT INTO partidas ( " +
                  "data, " +
                  "time_vencedor, " +
                  "valor_apostado) " +
                  "VALUES (" +
                  "@data, " +
                  "@time_vencedor, " +
                  "@valor_apostado) " +
                  "RETURNING id_partida";

            using (IDbCommand command = _database.CreateCommand(sql))
            {
                command.Parameters.Add(new NpgsqlParameter("@data", obj.data));
                command.Parameters.Add(new NpgsqlParameter("@time_vencedor", obj.timeVencedor));
                command.Parameters.Add(new NpgsqlParameter("@valor_apostado", obj.valorApostado));

                int idCriado = (int)command.ExecuteScalar();
                return idCriado;
            }
        }

        public void update(Partida obj)
        {
            string sql = "UPDATE partidas " +
                "SET time_vencedor = @time_vencedor " +
                "WHERE id_partida = @id_partida";

            using (IDbCommand command = _database.CreateCommand(sql))
            {
                command.Parameters.Add(new NpgsqlParameter("@id_partida", obj.id_partida));
                command.Parameters.Add(new NpgsqlParameter("@time_vencedor", obj.timeVencedor));

                command.ExecuteNonQuery();
            }
        }
    }
}
