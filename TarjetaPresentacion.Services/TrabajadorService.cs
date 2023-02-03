using Core;
using Core.GestionDeExcepciones;
using System.Collections.Generic;
using TarjetaPresentacion.Entities;
using TarjetaPresentacion.Repositories;
using TarjetaPresentacion.UOW;
using TarjetaPresentacion.UOW.Interface;

namespace TarjetaPresentacion.Services
{
    public class TrabajadorService : ITrabajadorService
    {
        private readonly IPrincipalUOW _principalUOW;

        public TrabajadorService(IPrincipalUOW principalUOW)
        {
            this._principalUOW = principalUOW;
        }

        public async Task<EstadoDeEjecucion<IEnumerable<Trabajador>>> GetAllAsync()
        {
       
            IEnumerable<Trabajador> listaEntidad = await this._principalUOW._trabajadorRepository.GetAllAsync();

            return new EstadoDeEjecucion<IEnumerable<Trabajador>>()
            {
                Status = true,
                TipoEstado = Tipo.Ok,
                Mensajes = new List<Mensaje>(),
                ValorObjeto = listaEntidad
            };


        }

        public async Task<EstadoDeEjecucion<Trabajador>> FindByIDAsync(string id)
        {

            Trabajador entidad = await this._principalUOW._trabajadorRepository.FindByIDAsync(id);

            return new EstadoDeEjecucion<Trabajador>()
            {
                Status = true,
                TipoEstado = Tipo.Ok,
                Mensajes = new List<Mensaje>(),
                ValorObjeto = entidad
            };

        }
    }
}