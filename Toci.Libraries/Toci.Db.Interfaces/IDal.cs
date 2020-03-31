using System;
using System.Linq;
using System.Linq.Expressions;

namespace Toci.Db.Interfaces
{
    public interface IDal<TModel>
    {
        IQueryable<TModel> Get(Expression<Func<TModel, int, bool>> where);

        bool Delete(TModel model);

        TModel Insert(TModel model);

        TModel Update(TModel model);
    }
}