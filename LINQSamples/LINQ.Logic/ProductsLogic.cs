using Linq.Data;
using LINQ.Logic.Clases;
using System.Linq;

namespace LINQ.Logic
{
    public class ProductsLogic : BaseLogic
    {
        public ProductsLogic(NorthwindContext dbContext) : base(dbContext)
        {
         
        }

        public IQueryable<ProductsDTO> GetProductsOutOfStock()
        {
            var productsOutStock = from p in context.Products
                                   where p.UnitsInStock == 0
                                   select new ProductsDTO
                                   {
                                       ProductID = p.ProductID,
                                       ProductName = p.ProductName,
                                   };
            return productsOutStock;
        }

        public IQueryable<ProductsDTO> GetExpensiveProducts()
        {
            var expensiveProducts = from p in context.Products
                                    where p.UnitsInStock > 0 && p.UnitPrice > 3
                                    select new ProductsDTO
                                    {
                                        ProductID = p.ProductID,
                                        ProductName = p.ProductName,
                                        UnitPrice = p.UnitPrice
                                    };

            return expensiveProducts;
        }

        public ProductsDTO ProductID789()
        {
            var product789 = context.Products.FirstOrDefault(p => p.ProductID == 789);

            if(product789 != null)
            {
                var productDTO = new ProductsDTO
                {
                    ProductID = product789.ProductID,
                    ProductName = product789.ProductName,
                    UnitPrice = product789.UnitPrice
                };

                return productDTO;
            }

            return null;
        }

        public IQueryable<ProductsDTO> OrderByName()
        {
            var query = context.Products
                        .OrderBy(p => p.ProductName)
                        .Select(p => new ProductsDTO
                        {
                            ProductID = p.ProductID,
                            ProductName = p.ProductName
                        });

            return query;
        }

        public IQueryable<ProductsDTO> OrderByUnit()
        {
            var query = (from p in context.Products
                         select new ProductsDTO
                         {
                             UnitsInStock = p.UnitsInStock,
                             ProductName = p.ProductName
                         })
                         .OrderByDescending(p => p.UnitsInStock);

            return query;
        }

        public ProductsDTO FirstElement()
        {
            var firstElement = context.Products.First();

            var productDTO = new ProductsDTO
            {
                ProductID = firstElement.ProductID,
                ProductName = firstElement.ProductName,
                UnitPrice = firstElement.UnitPrice
            };

            return productDTO;
        }
    }
}
