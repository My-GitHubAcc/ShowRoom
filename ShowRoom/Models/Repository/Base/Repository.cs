using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace ShowRoom.Models.Repository
{
    public abstract class Repository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class
        where TContext : DbContext, new()
    {
        TContext _entities = new TContext();
        public IQueryable<TEntity> All
        {
            get
            {
                return _entities.Set<TEntity>();
            }
        }

        public void Add(TEntity entity)
        {
            try
            {
                _entities.Set<TEntity>().Add(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(TEntity entity)
        {
            try
            {
                _entities.Set<TEntity>().Remove(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Edit(TEntity entity)
        {
            try
            {
                _entities.Entry(entity).State = EntityState.Modified;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TEntity Find(params object[] keyValues)
        {
            try
            {
                return _entities.Set<TEntity>().Find(keyValues);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                return All.Where(predicate);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Save()
        {
            _entities.SaveChanges();
        }
    }
}