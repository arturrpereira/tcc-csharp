using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace tcc_csharp.Data
{
    public class Postgre : Database
    {
        public override IDbCommand CreateCommand(string sqlCommand)
        {
            var command = ((NpgsqlConnection)connection).CreateCommand();
            command.CommandText = sqlCommand;

            if (transaction != null)
                command.Transaction = (NpgsqlTransaction)transaction;

            return command;
        }

        protected override void ClearPoolConnection(IDbConnection connection)
        {
            if (connection is NpgsqlConnection)
                NpgsqlConnection.ClearPool((NpgsqlConnection)connection);
        }

        protected override IDbConnection CreateNewConnection(string connectionString)
        {
            return new NpgsqlConnection(connectionString);
        }

        protected override string GetConnectionString()
        {
            var builder = new NpgsqlConnectionStringBuilder()
            {
                Host = "localhost",
                Database = "tccdb",
                Username = "postgres",
                Password = "1234",
                Port = 5432
            };

            return builder.ToString();
        }
    }
}
