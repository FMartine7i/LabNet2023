using Lab.EF.Entities;
using Lab.EF.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Lab.EF.Logic
{
    public class EmployeesLogic : BaseLogic, IABMLogic<EmployeesDTO>
    {
        public EmployeesLogic() : base() { }

        //GET ALL
        public List<EmployeesDTO> GetAll()
        {
            IEnumerable<Employees> employees = context.Employees.AsEnumerable();
            List<EmployeesDTO> result = employees.Select(e => new EmployeesDTO
            {
                EmployeeID = e.EmployeeID,
                FirstName = e.FirstName,
                LastName = e.LastName,
                City = e.City,
                Country = e.Country,
            }).ToList();

            return result;
        }


        // GET BY ID
        public EmployeesDTO GetEmployeeByID(int EmployeeID)
        {
            try 
            {
                var eEmployee = context.Employees.Find(EmployeeID);

                if(eEmployee != null)
                {
                    EmployeesDTO employeeDTO = new EmployeesDTO
                    {
                        EmployeeID = eEmployee.EmployeeID,
                        FirstName = eEmployee.FirstName,
                        LastName = eEmployee.LastName,                       
                        City = eEmployee.City,
                        Country = eEmployee.Country,
                    };

                    return employeeDTO;
                }
                else
                {
                    throw new Exception("No se ha encontrado la ID");
                }
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
        }

        // INSERT
        public EmployeesDTO Add(EmployeesDTO newEmployeeDTO)
        {
            var newEmployee = new Employees
            {
                FirstName = newEmployeeDTO.FirstName,
                LastName = newEmployeeDTO.LastName,
                City = newEmployeeDTO.City,
                Country = newEmployeeDTO.Country,
            };

            context.Employees.Add(newEmployee);
            context.SaveChanges();

            return newEmployeeDTO;
        }

        //DELETE
        public void Delete(int ID)
        {
            var employeeToDelete = context.Employees.SingleOrDefault(e => e.EmployeeID == ID);

            if (employeeToDelete == null)
            {
                throw new Exception($"No se ha encontrado la ID: {ID}");
            }

            try
            {
                context.Employees.Remove(employeeToDelete);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex}");
            }
        }


        //UPDATE
        public void Update(EmployeesDTO employeeDTO)
        {
            var employeeUpdate = context.Employees.Find(employeeDTO.EmployeeID);

            if (employeeUpdate != null)
            {
                employeeUpdate.FirstName = employeeDTO.FirstName;
                employeeUpdate.LastName = employeeDTO.LastName;
                employeeUpdate.City = employeeDTO.City;
                employeeUpdate.Country = employeeDTO.Country;
                context.SaveChanges();
            }
        }
    }
}
