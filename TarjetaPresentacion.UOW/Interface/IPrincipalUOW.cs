using Core.InfraestructuraADO.V2;

using TarjetaPresentacion.Repositories.Interface;

namespace TarjetaPresentacion.UOW.Interface
{
    public interface IPrincipalUOW : IUnityOfWork
    {
        public ITrabajadorRepository _trabajadorRepository { get; }
    }
}
