using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tcc_csharp.Data;
using tcc_csharp.model.entities;

namespace tcc_csharp.model.dao.impl
{
    public class FilaRepository : IFila
    {
        private readonly IDatabase _database;
        public FilaRepository(IDatabase database)
        {
            _database = database;
            _database.Open();
        }

        public void deleteById(Fila obj)
        {
            string sql = "DELETE " +
                "FROM Fila " +
                "WHERE fk_id_usuario = @id_usuario";

            using (IDbCommand command = _database.CreateCommand(sql))
            {
                command.Parameters.Add(new NpgsqlParameter("@id_usuario", obj.usuario.id_usuario));

                command.ExecuteNonQuery();
            }
            throw new NotImplementedException();
        }

        public List<Fila> findAll()
        {
            throw new NotImplementedException();
        }

        public void insert(Fila obj)
        {
            string sql = "INSERT INTO fila ( " +
                           "valor_sugerido, " +
                           "role, " +
                           "fk_id_usuario) " +
                           "VALUES (" +
                           "@valor_sugerido, " +
                           "@role, " +
                           "@fk_id_usuario)";

            using (IDbCommand command = _database.CreateCommand(sql))
            {
                command.Parameters.Add(new NpgsqlParameter("@valor_sugerido", obj.valorSugerido));
                command.Parameters.Add(new NpgsqlParameter("@role", obj.role));
                command.Parameters.Add(new NpgsqlParameter("@fk_id_usuario", obj.usuario.id_usuario));

                command.ExecuteNonQuery();
            }
        }
    }
}
