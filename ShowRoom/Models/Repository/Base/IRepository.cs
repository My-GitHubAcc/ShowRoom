using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShowRoom.Repository
{
    interface IRepository<TEntity>
    {
        IQueryable<TEntity> All { get; }

        TEntity Find(params object[] keyvalues);
        IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void Edit(TEntity entity);
        void Delete(TEntity entity);

        void Save();
    }
}
