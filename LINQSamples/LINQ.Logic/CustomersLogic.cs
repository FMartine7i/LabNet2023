using Linq.Data;
using Linq.Entities;
using LINQ.Logic.Clases;
using System;
using System.Linq;


namespace LINQ.Logic
{
    public class CustomersLogic : BaseLogic
    {
        public CustomersLogic(NorthwindContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<CustomersInfo> GetCustomers()
        {
            var customers = from c in context.Customers
                            select new CustomersInfo
                            {
                                CustomerID = c.CustomerID,
                                CustomerName = c.ContactName
                            };

            return customers;
        }

        public IQueryable<CustomersInfo> CustomersFromWA()
        {
            var customersInWA = context.Customers
                                .Where(c => c.Region == "WA")
                                .Select(c => new CustomersInfo
                                {
                                    CustomerID = c.CustomerID,
                                    CustomerName = c.ContactName,
                                    Region = c.Region
                                });

            return customersInWA;
        }

        public IQueryable<CustomersNames> CustomerNames()
        {
            var customerNames = from c in context.Customers
                                select new CustomersNames()
                                {
                                    UpperCaseName = c.ContactName.ToUpper(),
                                    LowerCaseName = c.ContactName.ToLower()
                                };
            return customerNames;
        }

        public IQueryable<CustomersInfo> CustomersWithOrders()
        {
            var CustomersWithOrders = from c in context.Customers
                                        join o in context.Orders on c.CustomerID equals o.CustomerID
                                        where c.Region == "WA" && o.OrderDate > new DateTime(1997, 1, 1)
                                        select new CustomersInfo()
                                        {
                                            CustomerName = c.ContactName,
                                            OrderDate = o.OrderDate
                                        };
            return CustomersWithOrders;
        }

        public IQueryable<CustomersInfo> Get3FirstCustomers()
        {
            var query = (from c in context.Customers
                         where c.Region == "WA"
                         select new CustomersInfo
                         {
                             CustomerID = c.CustomerID,
                             CustomerName = c.ContactName,
                         }).Take(3);

            return query;
        }
        
        public IQueryable<CustomerOrderSummary> OrderCount()
        {
            var query = context.Customers
                .Join(context.Orders,
                      customer => customer.CustomerID,
                      orders => orders.CustomerID,
                      (customer, orders) => new
                      {
                          CustomerName = customer.ContactName,
                          OrderID = orders.OrderID,
                          OrderDate = orders.OrderDate
                      })
                .GroupBy(result => result.CustomerName)
                .Select(group => new CustomerOrderSummary
                {
                    CustomerName = group.Key,
                    TotalOrders = group.Count(),
                    LastOrderDate = group.Max(result => result.OrderDate)
                });

            return query;
        }
    }
}
