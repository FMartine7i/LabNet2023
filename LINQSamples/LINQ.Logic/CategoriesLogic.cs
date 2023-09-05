using Linq.Data;
using Linq.Entities;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace LINQ.Logic
{
    public class CategoriesLogic : BaseLogic
    {
        public CategoriesLogic(NorthwindContext dbContext) : base(dbContext)
        {

        }

        public IQueryable<Categories> JoinProducts()
        {
            var categoryIDs = (from category in context.Categories
                         join product in context.Products
                         on category.CategoryID equals product.CategoryID
                         select category.CategoryID).Distinct();

            var query = (from category in context.Categories
                         where categoryIDs.Contains(category.CategoryID)
                         select category);
            return query;
        }
    }
}
