using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcc_csharp.Data
{
    public abstract class Database : IDatabase
    {
        protected IDbConnection connection = null;
        protected IDbTransaction transaction = null;

        protected abstract string GetConnectionString();

        protected abstract IDbConnection CreateNewConnection(string connectionString);

        protected abstract void ClearPoolConnection(IDbConnection connection);

        public abstract IDbCommand CreateCommand(string sqlCommand);

        public IDataReader ExecuteReader(string sqlCommand)
        {
            var cmd = CreateCommand(sqlCommand);
            return cmd.ExecuteReader();
        }

        public IDbConnection CurrentConnection
        {
            get
            {
                return connection;
            }
        }

        public IDbTransaction CurrentTransaction
        {
            get
            {
                return transaction;
            }
        }

        public IDbConnection Open()
        {
            if (connection == null || connection.State == ConnectionState.Closed)
                connection = CreateNewConnection(GetConnectionString());

            if (connection.State != ConnectionState.Open)
                connection.Open();

            return connection;
        }

        public void Close()
        {
            if (connection == null)
                return;

            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }

        public IDbTransaction BeginTrans()
        {
            if (transaction == null)
                transaction = connection.BeginTransaction();

            return transaction;
        }

        public void Commit()
        {
            if (transaction != null)
            {
                transaction.Commit();
                transaction.Dispose();
                transaction = null;
            }
        }

        public void Rollback()
        {
            if (transaction != null)
            {
                transaction.Rollback();
                transaction.Dispose();
                transaction = null;
            }
        }

        public virtual void Dispose()
        {
            ClearPoolConnection(connection);
            connection.Dispose();
        }
    }
}
