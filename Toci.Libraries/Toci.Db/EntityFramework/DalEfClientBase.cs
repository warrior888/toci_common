using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Toci.Db.Interfaces;

namespace Toci.Db.EntityFramework
{
    public abstract class DalEfClientBase<TModel> : IGenericDbClient<TModel>, IGenericDbHandle<TModel> where TModel : class
    {
        protected DbContext EntitiesDbContext;

        protected DalEfClientBase(DbContext entitiesDbContext)
        {
            EntitiesDbContext = entitiesDbContext;
        }

        public virtual IQueryable<TModel> Get(Expression<Func<TModel, int, bool>> @where)
        {
            return EntitiesDbContext.Set<TModel>().Where(@where);
        }

        public virtual TModel Set(TModel model)
        {
            TModel updated = EntitiesDbContext.Set<TModel>().Add(model);
            EntitiesDbContext.SaveChanges();

            return updated;
        }

        public IQueryable<TModel> Select(Expression<Func<TModel, int, bool>> @where)
        {
            return Get(@where);
        }

        public TModel Insert(TModel model)
        {
            return Set(model);
        }

        public virtual TModel Update(TModel model)
        {
            return Set(model);
        }

        public bool Delete(TModel model)
        {
            EntitiesDbContext.Set<TModel>().Remove(model);
            EntitiesDbContext.SaveChanges();

            return true;
        }
    }
}