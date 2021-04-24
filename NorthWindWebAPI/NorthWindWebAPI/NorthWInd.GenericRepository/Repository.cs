 using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NorthWind.GenericRepository.Common.Repositories;
using NorthWind.GenericRepository.Common.Infrastructure;
using NorthWind.GenericRepository.Common.DataContext;
using System.Data.Entity;

namespace NorthWInd.GenericRepository
{
    public class Repository<TEntity>: IRepository<TEntity> where TEntity:class, IObjectState
    {
        private IDataContext _context;

        DbContext dbContext;

        public Repository(IDataContext context)
        {
            _context = context;

             dbContext = context as DbContext;
        }

        protected DbSet<TEntity> DbSet
        {
            get { return dbContext.Set<TEntity>(); }
        }

        public TEntity Find(params object[] parameters)
        {
            return DbSet.Find(parameters);
        }

        public IQueryable<TEntity> SqlQuery(string query, params object[] parameters)
        {
            return DbSet.SqlQuery(query, parameters).AsQueryable();
        }

        public void Insert(TEntity entity)
        {
            entity.ObjectState = ObjectState.Added;
            entity.EnteredDate = DateTime.Now;  
            DbSet.Attach(entity);
            _context.SyncObjectState(entity);
        }

        public void InsertGraphRange(IEnumerable<TEntity> entities)
        {
            DbSet.AddRange(entities);
        }

        public void InsertRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                Insert(entity);
            }
        }

        public void Update(TEntity entity)
        {
            entity.ObjectState = ObjectState.Modified;            
            entity.LastModifiedDate = DateTime.Now;
            DbSet.Attach(entity);
            _context.SyncObjectState(entity);
        }

        public void Delete(TEntity entity)
        {
            entity.ObjectState = ObjectState.Added;
            DbSet.Attach(entity);
            _context.SyncObjectState(entity);        
        }

        public void Delete(int Id)
        {
           TEntity entityDelete= DbSet.Find(Id);
            this.Delete(entityDelete);
        }

        public IRepositoryQuery<TEntity> Query()
        {
            throw new NotImplementedException();
        }
        public IRepositoryQuery<TEntity> Query(Expression<Func<TEntity, bool>> query)
        {
            throw new NotImplementedException();
        }


        public IQueryable<TEntity> Queriable()
        {
            return DbSet.AsQueryable();
        }

        IRepository<T> GetRepository<T>() where T:class,IObjectState
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
