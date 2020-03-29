using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Toci.Db.Interfaces
{
    public interface IGenericDbHandle<TModel>
    {
        IQueryable<TModel> Select(Expression<Func<string, List<TModel>>> where);

        TModel Insert(TModel model);

        TModel Update(TModel model);

        bool Delete(TModel model);
    }
}