using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Lab.EF.Logic
{
    public class EmployeesLogic : BaseLogic, IABMLogic<Employees>
    {
        public void Add(Employees item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
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
