using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace Lab.WebAPI.Controllers
{
    public class EmployeesController : ApiController
    {
        private readonly EmployeesLogic _logic;

        public EmployeesController(EmployeesLogic logic)
        {
            _logic = logic;
        }

        // GET: api/Employees
        public IHttpActionResult GetEmployees()
        {
            try
            {
                var employees = _logic.GetAll();
                var employeeViews = employees.Select(e => new EmployeesView
                {
                    EmployeeID = e.EmployeeID,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    HireDate = e.HireDate,
                    City = e.City,
                    Country = e.Country,
                });

                return Ok(employeeViews);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // GET: api/Employees/{id}
        [ResponseType(typeof(EmployeesView))]
        public IHttpActionResult GetEmployeesID(int ID)
        {
            try
            {
                var employees = _logic.GetEmployeeByID(ID);

                if (employees == null)
                {
                    return NotFound();
                }

                EmployeesView eView = new EmployeesView
                {
                    FirstName = employees.FirstName,
                    LastName = employees.LastName,
                    HireDate = employees.HireDate,
                    City = employees.City,
                    Country = employees.Country,
                };

                return Ok(eView);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // POST: api/Employees
        [ResponseType(typeof(EmployeesView))]
        public IHttpActionResult PostEmployee(EmployeesView employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try 
            { 
                var newEmployee = new Employees
                {
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    HireDate = employee.HireDate,
                    City = employee.City,
                    Country = employee.Country,
                };

                _logic.Add(newEmployee);

                return CreatedAtRoute("DefaultApi", new { id = newEmployee.EmployeeID }, newEmployee);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }            
        }

        // PUT: api/Employees/{id}
        [ResponseType(typeof(void))]
        public IHttpActionResult UpdateEmployee(int id, EmployeesUpdate employee)
        {
            if (id != employee.EmployeeID)
            {
                return BadRequest("Las ID no coinciden");
            }

            if (ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            { 
                var eEmployee = _logic.GetEmployeeByID(id);

                if (eEmployee == null)
                {
                    return NotFound();
                }

                eEmployee.FirstName = employee.FirstName;
                eEmployee.LastName = employee.LastName;
                eEmployee.HireDate = employee.HireDate;
                eEmployee.City = employee.City;
                eEmployee.Country = employee.Country;

                _logic.Update(eEmployee);
                return StatusCode(HttpStatusCode.NoContent);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }          
        }

        // DELETE: api/Employees/{id}
        [ResponseType(typeof(EmployeesView))]
        public IHttpActionResult DeleteEmployee(int id)
        {
            try
            { 
                var eEmployee = _logic.GetEmployeeByID(id);

                if (eEmployee == null)
                {
                    return NotFound();
                }

                _logic.Delete(id);
                return Ok("Employee deleted");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}