using Linq.Data;
using Linq.Entities;
using System;
using System.Linq;

namespace LINQ.Logic
{
    public class ProductsLogic : BaseLogic
    {
        public ProductsLogic(NorthwindContext dbContext) : base(dbContext)
        {
         
        }
        /*public IQueryable<Products> GetProductsOutOfStock()
        {
            return context.Products.Where(p => p.UnitsInStock == 0);
        }*/

        public IQueryable<Products> GetProductsOutOfStock()
        {
            var productsOutStock = from p in context.Products
                                   where p.UnitsInStock == 0
                                   select p;
            return productsOutStock;
        }

        public IQueryable<Products> GetExpensiveProducts()
        {
            var expensiveProducts = from p in context.Products
                                    where p.UnitsInStock > 0 && p.UnitPrice > 3
                                    select p;

            return expensiveProducts;
        }

        public Products ProductID789()
        {
            var product789 = context.Products.FirstOrDefault(p => p.ProductID == 789);

            return product789;
        }

        public IQueryable<Products> OrderByName()
        {
            var query = context.Products.OrderBy(p => p.ProductName);

            return query;
        }

        public IQueryable<Products> OrderByUnit()
        {
            var query = (from p in context.Products
                         select p).OrderByDescending(p => p.UnitsInStock);

            return query;
        }

        public Products FirstElement()
        {
            var firstElement = context.Products.First();

            return firstElement;
        }
    }
}
