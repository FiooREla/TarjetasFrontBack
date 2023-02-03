using TarjetaPresentacion.Entities;

namespace TarjetaPresentacion.Repositories.Interface
{
    public interface ITrabajadorRepository
    {
        Task<Trabajador> FindByIDAsync(string id);
        Task<IEnumerable<Trabajador>> GetAllAsync();
    }
}