using Linq.Data;
using Linq.Entities;
using LINQ.Logic.Clases;
using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQ.Logic
{
    public class CustomersLogic : BaseLogic
    {
        public CustomersLogic(NorthwindContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<Customers> GetCustomers()
        {
            var customers = from c in context.Customers
                            select c;

            return customers;
        }

        public IQueryable<Customers> CustomersFromWA()
        {
            var customersInWA = context.Customers.Where(c => c.Region == "WA");

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

        public IQueryable<CustomersWA> CustomersWithOrders()
        {
            var CustomersWithOrders = from c in context.Customers
                                        join o in context.Orders on c.CustomerID equals o.CustomerID
                                        where c.Region == "WA" && o.OrderDate > new DateTime(1997, 1, 1)
                                        select new CustomersWA()
                                        {
                                            CustomerName = c.ContactName,
                                            OrderDate = o.OrderDate
                                        };
            return CustomersWithOrders;
        }

        public IQueryable<Customers> Get3FirstCustomers()
        {
            var query = (from c in context.Customers
                         where c.Region == "WA"
                         select c).Take(3);
            return query;
        }
    }
}
