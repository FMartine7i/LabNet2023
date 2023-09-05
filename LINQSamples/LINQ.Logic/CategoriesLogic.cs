using Linq.Data;
using Linq.Entities;
using System.Linq;
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
            var query = context.Categories.GroupJoin(context.Products,
                                                    category => category.CategoryID,
                                                    product => product.CategoryID,
                                                    (category, products) => new { Category = category, Products = products})
                                                    .SelectMany(group => group.Products.DefaultIfEmpty(),
                                                    (group, product) => new { Category = group.Category, Product = product})
                                                    .Select(group => group.Category).Distinct();
            return query;
        }
    }
}
