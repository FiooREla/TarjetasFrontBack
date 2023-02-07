using Core.InfraestructuraADO.V2;
using System.Data.Odbc;
using System.Data.SqlClient;

namespace TarjetaPresentacion.Context
{
    public interface IPrincipalContext : IContext
    {
        SqlConnection _connection { get; }
        SqlTransaction _transaction { get; }
    }
}