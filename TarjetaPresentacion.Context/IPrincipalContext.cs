using Core.InfraestructuraADO.V2;
using System.Data.Odbc;

namespace TarjetaPresentacion.Context
{
    public interface IPrincipalContext : IContext
    {
        OdbcConnection _connection { get; }
        OdbcTransaction _transaction { get; }
    }
}