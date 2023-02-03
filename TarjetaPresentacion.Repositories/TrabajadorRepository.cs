
using Dapper;
using System.Data;
using TarjetaPresentacion.Context;
using TarjetaPresentacion.Entities;
using TarjetaPresentacion.Repositories.Interface;

namespace TarjetaPresentacion.Repositories
{
    public class TrabajadorRepository : ITrabajadorRepository
    {
        private IDbConnection _connection;
        private IDbTransaction _transaction;

        public TrabajadorRepository(IPrincipalContext principalContext)
        {
            _transaction = principalContext._transaction;
            _connection = principalContext._connection;
        }

        public async Task<IEnumerable<Trabajador>> GetAllAsync()
        {
            string srtComandoSQL = "SELECT  empID, lastName, firstName, jobTitle FROM  OHEM WHERE  Active != 'N' AND nempID=@nempID  ORDER BY  lastName";

            IEnumerable<Trabajador> listaEntidad = await _connection.QueryAsync<Trabajador>(srtComandoSQL, _transaction);

            return listaEntidad;
        }
        public async Task<Trabajador> FindByIDAsync(string id)
        {
            string srtComandoSQL = "SELECT  empID, lastName, firstName, jobTitle FROM  OHEM WHERE  Active != 'N' AND nempID=@nempID  ORDER BY  lastName";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("nempID", id);
            Trabajador entidad = await _connection.QueryFirstOrDefaultAsync<Trabajador>(srtComandoSQL, parameters, _transaction);

            return entidad;
        }

    }
}