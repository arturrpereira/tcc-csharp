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
    public class FilaRepository : IFila
    {
        private readonly IDatabase _database;
        public FilaRepository(IDatabase database)
        {
            _database = database;
            _database.Open();
        }

        public void deleteById(int userid)
        {
            string sql = "DELETE " +
                "FROM Fila " +
                "WHERE fk_id_usuario = @id_usuario";

            using (IDbCommand command = _database.CreateCommand(sql))
            {
                command.Parameters.Add(new NpgsqlParameter("@id_usuario", userid));

                command.ExecuteNonQuery();
            }
        }

        public List<Fila> findAll()
        {
            string sql = "SELECT * " +
                "FROM fila";

            using (IDbCommand command = _database.CreateCommand(sql))
            {
                using (IDataReader reader = command.ExecuteReader())
                {
                    List<Fila> list = new List<Fila>();

                    while (reader.Read())
                    {
                        Fila fila = new Fila();

                        fila.valorSugerido = reader.GetFloat("valor_sugerido");
                        fila.role = reader.GetString("role");
                        fila.usuario.id_usuario = reader.GetInt32("fk_id_usuario");

                        list.Add(fila);
                    }

                    return list;
                }
            }
        }
    }
}
