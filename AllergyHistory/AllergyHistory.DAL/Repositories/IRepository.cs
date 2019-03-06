using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllergyHistory.DAL.Repositories
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        IQueryable<TEntity> GetAll_Q();
        TEntity Get(long id);
        void Add(TEntity entity);
        void Update(TEntity dbEntity, TEntity entity);
        void Delete(TEntity entity);
    }
}
