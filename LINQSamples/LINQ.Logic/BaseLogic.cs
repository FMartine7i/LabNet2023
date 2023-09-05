using Linq.Data;
using System;

namespace LINQ.Logic
{
    public class BaseLogic : IDisposable
    {
        protected readonly NorthwindContext context;

        public BaseLogic(NorthwindContext dbContext)
        {
            context = dbContext;
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
