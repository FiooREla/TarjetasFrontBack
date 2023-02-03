using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaPresentacion.Repositories
{
    public class RepositoryIDB 
    {
        protected OdbcTransaction _transaction;

        protected OdbcConnection _connection;


        protected OdbcCommand CreateCommand(string query)
        {
            OdbcCommand mySqlCommand = new OdbcCommand(query, _connection, _transaction);
            mySqlCommand.CommandTimeout = 900;
            return mySqlCommand;
        }

    }
}
