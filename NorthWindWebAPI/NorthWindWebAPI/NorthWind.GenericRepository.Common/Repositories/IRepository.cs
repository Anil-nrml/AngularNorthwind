using NorthWind.GenericRepository.Common.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.GenericRepository.Common.Repositories
{
    public interface IRepository<TEntity> where TEntity:class, IObjectState
    {
        TEntity Find(params object[] parameters);
        IQueryable<TEntity> SqlQuery(string query, params object[] parameters);
        void Insert(TEntity entity);
        void InsertRange(IEnumerable<TEntity> entities);
        void InsertGraphRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Delete(int Id);
        void Delete(TEntity entity);
        IRepositoryQuery<TEntity> Query(Expression<Func<TEntity, bool>> query);
        IRepositoryQuery<TEntity> Query();
        IQueryable<TEntity> Queriable(); 
        //IRepository<T> GetRepository<T>() where T : class, IObjectState;
        int SaveChanges();
    }
}
