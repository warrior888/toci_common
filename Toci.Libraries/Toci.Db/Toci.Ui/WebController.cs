using System.Data.Entity;
using Toci.Ui.Interfaces;

namespace Toci.Ui
{
    public abstract class WebController : IWebController
    {
        protected DbContext Database;

        protected WebController(DbContext context)
        {
            Database = context;
        }
    }
}