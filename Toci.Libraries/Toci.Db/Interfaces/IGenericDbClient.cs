using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Toci.Db.Interfaces
{
    public interface IGenericDbClient<TModel>
    {
        IQueryable<TModel> Get(Expression<Func<string, List<TModel>>> where);

        TModel Set(TModel model);
    }
}