using NorthWind.GenericRepository.Common.Infrastructure;
using NorthWind.GenericRepository.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace NorthWInd.GenericRepository
{
    public class RepositoryQuery<TEntity> : IRepositoryQuery<TEntity> where TEntity : class, IObjectState
    {
        public IRepositoryQuery<TEntity> Include(Expression<Func<TEntity, object>> expression)
        {
            throw new NotImplementedException();
        }

        public IRepositoryQuery<TEntity> OrderBy(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Select()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Select<TResult>(Expression<Func<TEntity, TResult>> selector = null)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> SelectAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> SelectMany()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> SelectMany<TResult>(Expression<Func<TEntity, TResult>> selector = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> SelectPage(int page, int pageSize, out int totalCount)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> SelectTopRows(int rowCount)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> SqlQuery(string query, params object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
