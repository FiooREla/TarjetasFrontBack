using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public interface IContext : IDisposable
    {
        Task SaveChangesAsync();
        void SaveChanges();
        Task RollbackAsync();
        void Rollback();

    }
}
