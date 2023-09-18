using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.WebAPI.Models
{
    public class EmployeesUpdate
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? HireDate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}