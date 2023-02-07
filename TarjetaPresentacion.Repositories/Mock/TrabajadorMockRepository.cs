
using Dapper;
using System.Data;
using TarjetaPresentacion.Context;
using TarjetaPresentacion.Entities;
using TarjetaPresentacion.Repositories.Interface;

namespace TarjetaPresentacion.Repositories.Mock
{
    public class TrabajadorMockRepository : ITrabajadorRepository
    {
        private IDbConnection _connection;
        private IDbTransaction _transaction;

        private List<Trabajador> _listaEntidad = new List<Trabajador>();

        public TrabajadorMockRepository(IPrincipalContext principalContext)
        {
            _transaction = principalContext._transaction;
            _connection = principalContext._connection;
           
        }

        public async Task<IEnumerable<Trabajador>> GetAllAsync()
        {
            return _listaEntidad;
        }
        public async Task<Trabajador> FindByIDAsync(string id)
        {
            return _listaEntidad.FirstOrDefault(le => le.vendor == id);
        }

    }
}