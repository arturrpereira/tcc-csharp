using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcc_csharp.Data
{
    public interface IDatabase : IDisposable
    {
        IDbConnection CurrentConnection { get; }

        IDbTransaction CurrentTransaction { get; }

        IDbConnection Open();

        IDbCommand CreateCommand(string sqlCommand);

        IDataReader ExecuteReader(string sqlCommand);

        void Close();

        IDbTransaction BeginTrans();

        void Commit();

        void Rollback();
    }
}
