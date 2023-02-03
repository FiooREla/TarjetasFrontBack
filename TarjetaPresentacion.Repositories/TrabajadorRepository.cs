using Context;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using TarjetaPresentacion.Entities;

namespace TarjetaPresentacion.Repositories
{
    public class TrabajadorRepository : RepositoryIDB
    {
        

        public TrabajadorRepository(PrincipalContext principalContext)
        {
            _transaction = principalContext._transaction    ;
            _connection = principalContext._connection ;
        }

        public async Task<IEnumerable<Trabajador>> GetAll()
        {
            string srtComandoSQL = "SELECT  \"empID\", \"lastName\", \"firstName\", \"jobTitle\" FROM \"OHEM\" WHERE \"Active\" != 'N'  ORDER BY \"lastName\"";

            IEnumerable<Trabajador> listaEntidad =await _connection.QueryAsync<Trabajador>(srtComandoSQL);
           
            return listaEntidad;
        }
        public async Task<Trabajador> FindByIDAsync( string id )
        {
            string srtComandoSQL = "SELECT  empID, lastName, firstName, jobTitle FROM  OHEM WHERE  Active != 'N' AND nempID=@nempID  ORDER BY  lastName";
            DynamicParameters parameters= new DynamicParameters();
            parameters.Add("nempID", id);
            Trabajador entidad = await _connection.QueryFirstOrDefaultAsync<Trabajador>(srtComandoSQL , parameters);

            return entidad;
        }

    }
}