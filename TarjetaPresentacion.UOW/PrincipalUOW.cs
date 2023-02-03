using Core.InfraestructuraADO.V2;
using TarjetaPresentacion.Context;
using TarjetaPresentacion.Repositories;
using TarjetaPresentacion.Repositories.Interface;
using TarjetaPresentacion.UOW.Interface;

namespace TarjetaPresentacion.UOW
{
    public class PrincipalUOW : IPrincipalUOW
    {
        private readonly IPrincipalContext _principalContext;
        public ITrabajadorRepository _trabajadorRepository { get; }
        public PrincipalUOW(IPrincipalContext principalContext , ITrabajadorRepository trabajadorRepository)
        {
            _principalContext = principalContext;
            _trabajadorRepository = trabajadorRepository;
        }


        public void SaveChanges()
        {
            _principalContext.SaveChanges();
           
        }

        public async Task SaveChangesAsync(CancellationToken cancellationToken)
        {
            await _principalContext.SaveChangesAsync(cancellationToken);
        }
    }
}