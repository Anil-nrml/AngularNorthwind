using NorthWind.GenericRepository.Common.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.GenericRepository.Common.DataContext
{
    public interface IDataContext:IDisposable
    {
        int SaveChanges();
        void SyncObjectState<TEntity>(TEntity entity) where TEntity : class, IObjectState;

        void SyncObjectsStatePostCommit();
    }
}
