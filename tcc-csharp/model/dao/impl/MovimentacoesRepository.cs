using Npgsql;
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
    public class MovimentacoesRepository : IMovimentacoes
    {
        private readonly IDatabase _database;

        public MovimentacoesRepository(IDatabase database)
        {
            _database = database;
            _database.Open();
        }

        public List<Movimentacao> findByUser(Usuario obj)
        {
            string sql = "SELECT " +
                "movimentacoes.id_movimentacao," +
                "movimentacoes.valor," +
                "movimentacoes.tipooperacao," +
                "movimentacoes.fk_id_usuario," +
                "movimentacoes.fk_id_partida," +
                "partidas.id_partida," +
                "partidas.data," +
                "partidas.time_vencedor," +
                "partidas.valor_apostado " +
                "FROM movimentacoes " +
                "INNER JOIN partidas ON movimentacoes.fk_id_partida = partidas.id_partida " +
                "WHERE movimentacoes.fk_id_usuario = @id_usuario " +
                "ORDER BY data";

            using (IDbCommand command = _database.CreateCommand(sql))
            {
                command.Parameters.Add(new NpgsqlParameter("@id_usuario", obj.id_usuario));

                using (IDataReader reader = command.ExecuteReader())
                {
                    List<Movimentacao> list = new List<Movimentacao>();

                    while (reader.Read())
                    {
                        Movimentacao movimentacao = new Movimentacao();
                        movimentacao.id_movimentacao = reader.GetInt32("id_movimentacao");
                        movimentacao.valor = reader.GetFloat("valor");
                        movimentacao.tipooperacao = reader.GetInt32("tipooperacao");

                        Partida partida = new Partida();
                        partida.id_partida = reader.GetInt32("id_partida");
                        partida.data = reader.GetDateTime("data");
                        partida.timeVencedor = reader.GetInt32("time_vencedor");
                        partida.valorApostado = reader.GetFloat("valor_apostado");

                        movimentacao.usuario = obj;
                        movimentacao.Partida = partida;

                        list.Add(movimentacao);
                    }
                    return list;
                }
            }
        }
    }
}
