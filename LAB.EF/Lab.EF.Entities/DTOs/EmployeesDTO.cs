using System;

namespace Lab.EF.Entities.DTOs
{
    public class EmployeesDTO
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? HireDate { get; set; }
        public string City { get; set; }
    }
}
