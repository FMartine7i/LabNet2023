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

        public IQueryable<CustomersNames> CustomersNames()
        {
            var customerNames = from c in context.Customers
                                select new
                                {
                                    UpperCaseName = c.ContactName.ToUpper(),
                                    LowerCaseName = c.ContactName.ToLower()
                                };
            return customerNames;
        }

        public List<Customers> CustomersWithOrders()
        {
            var CustomersWithOrders = from c in context.Customers
                                        join o in context.Orders on c.CustomerID equals o.CustomerID
                                        where c.Region == "WA" && o.OrderDate > new DateTime(1997, 1, 1)
                                        select new
                                        {
                                            CustomerName = c.ContactName,
                                            OrderDate = o.OrderDate
                                        };
            return CustomersWithOrders;
        }
    }
}
