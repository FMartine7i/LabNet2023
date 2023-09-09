using System;

namespace LINQ.Logic.Clases
{
    public class CustomersNames
    {
        public string UpperCaseName { get; set; }
        public string LowerCaseName { get; set; }
    }

    public class CustomerOrderSummary
    {
        public string CustomerName { get; set; }
        public int TotalOrders { get; set; }
        public DateTime? LastOrderDate { get; set; }
    }
}


