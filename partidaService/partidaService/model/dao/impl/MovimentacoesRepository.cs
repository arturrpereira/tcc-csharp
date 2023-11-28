using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using partidaService.Common.Extensions;
using partidaService.model.entities;
using partidaService.model.dao;
using tcc_csharp.Data;

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

        public void insert(Movimentacao obj)
        {
            string sql = "INSERT INTO movimentacoes ( " +
                "valor, " +
                "tipooperacao, " +
                "fk_id_usuario, " +
                "fk_id_partida) " +
                "VALUES (" +
                "@valor, " +
                "@tipooperacao, " +
                "@fk_id_usuario, " +
                "@fk_id_partida)";

            using (IDbCommand command = _database.CreateCommand(sql))
            {
                command.Parameters.Add(new NpgsqlParameter("@valor", obj.valor));
                command.Parameters.Add(new NpgsqlParameter("@tipooperacao", obj.tipooperacao));
                command.Parameters.Add(new NpgsqlParameter("@fk_id_usuario", obj.usuario.id_usuario));
                command.Parameters.Add(new NpgsqlParameter("@fk_id_partida", obj.Partida.id_partida));

                command.ExecuteNonQuery();
            }

        }
    }
}
