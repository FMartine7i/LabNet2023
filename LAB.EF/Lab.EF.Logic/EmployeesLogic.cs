using Lab.EF.Entities;
using System.Collections.Generic;
using System.Linq;


namespace Lab.EF.Logic
{
    public class EmployeesLogic : BaseLogic, IABMLogic<Employees>
    {

        public void Add(Employees newEmployee)
        {
            context.Employees.Add(newEmployee);
            context.SaveChanges();
        }

        public Employees GetEmployeeByID(int EmployeeID)
        {
            var eContext = context.Employees;
            return eContext.FirstOrDefault(e => e.EmployeeID == EmployeeID);
        }

        public void Delete(int ID)
        {
            var employeeToDelete = context.Employees.SingleOrDefault(e => e.EmployeeID == ID);

            if (employeeToDelete != null)
            {
                context.Employees.Remove(employeeToDelete);
                context.SaveChanges();
            }
        }

        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }

        public void Update(Employees employee)
        {
            var employeeUpdate = context.Employees.Find(employee.EmployeeID);

            if (employeeUpdate != null)
            {
                employeeUpdate.FirstName = employee.FirstName;
                employeeUpdate.LastName = employee.LastName;
                employeeUpdate.City = employee.City;
                employeeUpdate.Country = employee.Country;
                employeeUpdate.HireDate = employee.HireDate;
                context.SaveChanges();
            }
        }
    }
}
