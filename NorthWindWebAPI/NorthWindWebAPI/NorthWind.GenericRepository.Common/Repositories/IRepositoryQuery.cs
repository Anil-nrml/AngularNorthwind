using NorthWind.GenericRepository.Common.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.GenericRepository.Common.Repositories
{
    public interface IRepositoryQuery<TEntity> where TEntity:IObjectState
    {
        IRepositoryQuery<TEntity> OrderBy(Func<IQueryable<TEntity>,IOrderedQueryable<TEntity>> orderBy);
        IRepositoryQuery<TEntity> Include(Expression<Func<TEntity, object>> expression);
        IEnumerable<TEntity> SelectMany<TResult>(Expression<Func<TEntity, TResult>> selector = null);
        IEnumerable<TEntity> Select<TResult>(Expression<Func<TEntity, TResult>> selector = null);
        IEnumerable<TEntity> SelectTopRows(int rowCount);
        IEnumerable<TEntity> Select();
        IEnumerable<TEntity> SelectMany();
        Task<IEnumerable<TEntity>> SelectAsync();
        IQueryable<TEntity> SqlQuery(string query, params object[] parameters);       
        IEnumerable<TEntity> SelectPage(int page, int pageSize, out int totalCount);
        
    }
}
