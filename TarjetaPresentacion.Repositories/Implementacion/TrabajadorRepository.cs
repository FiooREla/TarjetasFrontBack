
using Dapper;
using System.Data;
using TarjetaPresentacion.Context;
using TarjetaPresentacion.Entities;
using TarjetaPresentacion.Repositories.Interface;

namespace TarjetaPresentacion.Repositories.Implementacion
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
            string srtComandoSQL = @"SELECT GeneralEmpleado.vendor AS vendor,
                                    GeneralEmpleado.apellidopaterno AS apellidopaterno,
                                    GeneralEmpleado.apellidomaterno AS apellidomaterno,
                                    GeneralEmpleado.nombres AS nombres,
                                    GeneralEmpleado.sexo AS sexo,
                                    titulopuesto.titulopuesto AS puesto,
                                    MaestroVendor.direccionvendor AS direccionvendor,
                                    MaestroVendor.direccionnumero AS direccionnumero,
                                    MaestroVendor.telefonocelular AS telefonocelular,
                                    VendorEmpleado.nombrecorreoelectronico AS nombrecorreoelectronico,
                                    sys_est_tabla_combinaciones.columna4 AS columna4,
                                    sys_est_tabla_combinaciones.columna3 AS gerencia,
                                    sys_est_tabla_combinaciones.columna5 AS area,
                                    SYS_TabladeTablas.filler_str_02 AS subgerencia
        
                                    FROM GeneralEmpleado
                                    left join MaestroVendor  on GeneralEmpleado.Vendor = MaestroVendor.Vendor 
                                    left join VendorEmpleado VendorEmpleado on GeneralEmpleado.Vendor = VendorEmpleado.Vendor 
                                    left join sys_est_tabla_combinaciones on GeneralEmpleado.codigoorgano =  sys_est_tabla_combinaciones.codigocombinacion
                                    left join SYS_TabladeTablas on SYS_TabladeTablas.codigo= sys_est_tabla_combinaciones.columna4 
									left join titulopuesto on GeneralEmpleado.codigopuesto= titulopuesto.codigopuesto  
                                    where  GeneralEmpleado.clasepuesto IN( 'EMP','PRA') and estadovendor='A'";

            IEnumerable<Trabajador> listaEntidad = await _connection.QueryAsync<Trabajador>(srtComandoSQL,transaction : _transaction);

            return listaEntidad;
        }
        public async Task<Trabajador> FindByIDAsync(string id)
        {
            string srtComandoSQL = @"SELECT GeneralEmpleado.vendor AS vendor,
                                    GeneralEmpleado.apellidopaterno AS apellidopaterno,
                                    GeneralEmpleado.apellidomaterno AS apellidomaterno,
                                    GeneralEmpleado.nombres AS nombres,
                                    GeneralEmpleado.sexo AS sexo,
                                    titulopuesto.titulopuesto AS puesto,
                                    MaestroVendor.direccionvendor AS direccionvendor,
                                    MaestroVendor.direccionnumero AS direccionnumero,
                                    MaestroVendor.telefonocelular AS telefonocelular,
                                    VendorEmpleado.nombrecorreoelectronico AS nombrecorreoelectronico,
                                    sys_est_tabla_combinaciones.columna4 AS columna4,
                                    sys_est_tabla_combinaciones.columna3 AS gerencia,
                                    sys_est_tabla_combinaciones.columna5 AS area,
                                    SYS_TabladeTablas.filler_str_02 AS subgerencia
        
                                    FROM GeneralEmpleado
                                    left join MaestroVendor  on GeneralEmpleado.Vendor = MaestroVendor.Vendor 
                                    left join VendorEmpleado VendorEmpleado on GeneralEmpleado.Vendor = VendorEmpleado.Vendor 
                                    left join sys_est_tabla_combinaciones on GeneralEmpleado.codigoorgano =  sys_est_tabla_combinaciones.codigocombinacion
                                    left join SYS_TabladeTablas on SYS_TabladeTablas.codigo= sys_est_tabla_combinaciones.columna4 
									left join titulopuesto on GeneralEmpleado.codigopuesto= titulopuesto.codigopuesto  
                                    where  GeneralEmpleado.clasepuesto IN( 'EMP','PRA') and estadovendor='A' AND GeneralEmpleado.vendor=@vendor";
            
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("vendor", id);
            Trabajador entidad = await _connection.QueryFirstOrDefaultAsync<Trabajador>(srtComandoSQL,param : parameters, transaction: _transaction);

            return entidad;
        }

    }
}