using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class PrincipalContext : IContext
    {

        public OdbcConnection _connection { private set; get; }
        public OdbcTransaction _transaction { private set; get;  }

        public PrincipalContext(PrincipalConnection _principalConnection)
        {
            this._connection = new OdbcConnection(_principalConnection.Cadena);
            this._connection.Open();
            this._transaction = this._connection.BeginTransaction();


        }
        public void Rollback()
        {
            _transaction.Rollback();
        }

        public async Task RollbackAsync()
        {
            await _transaction.RollbackAsync();
        }

        public void SaveChanges()
        {
            _transaction.Commit();
        }

        public async  Task SaveChangesAsync()
        {
            await _transaction.CommitAsync();
        }

        public void Dispose()
        {
            if (_transaction != null)
            {
                _transaction.Dispose();
            }

            if (_connection != null)
            {
                _connection.Close();
                _connection.Dispose();
            }
        }
    }
}
