using Core;
using TarjetaPresentacion.Entities;

namespace TarjetaPresentacion.Services
{
    public interface ITrabajadorService
    {
        Task<EstadoDeEjecucion<Trabajador>> FindByIDAsync(string id);
        Task<EstadoDeEjecucion<IEnumerable<Trabajador>>> GetAllAsync();
    }
}