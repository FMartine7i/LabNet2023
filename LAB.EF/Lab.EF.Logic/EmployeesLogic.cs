using Lab.EF.Entities;
using System;
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

        public void Update(Employees categories)
        {
            throw new NotImplementedException();
        }
    }
}
