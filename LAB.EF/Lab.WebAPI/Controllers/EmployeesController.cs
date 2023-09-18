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
        // GET: Employees
        private readonly EmployeesLogic _logic;

        public EmployeesController(EmployeesLogic logic)
        {
            _logic = logic;
        }

        // GET: api/Suppliers
        public IEnumerable<EmployeesView> GetEmployees()
        {
            var employees = _logic.GetAll();

            return employees.Select(x => new EmployeesView
            {
                EmployeeID = x.EmployeeID,
                FirstName = x.FirstName,
                LastName = x.LastName,
                HireDate = x.HireDate,
                City = x.City,
                Country = x.Country,
            });
        }

        // GET: api/Suppliers
        [ResponseType(typeof(EmployeesView))]
        public IHttpActionResult GetEmployeesID(int ID)
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

        // POST: api/Suppliers
        [ResponseType(typeof(EmployeesView))]
        public IHttpActionResult PostEmployee(EmployeesView employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newEmployee = new Employees
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                HireDate = employee.HireDate,
                City = employee.City,
                Country = employee.Country,
            };

            try
            {
                _logic.Add(newEmployee);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

            return CreatedAtRoute("DefaultApi", new { id = newEmployee.EmployeeID }, newEmployee);
        }

        // PUT: api/Suppliers/{id}
        [ResponseType(typeof(void))]
        public IHttpActionResult UpdateEmployee(int id, EmployeesUpdate employee)
        {
            if (ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employee.EmployeeID)
            {
                return BadRequest("Las ID no coincide");
            }

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

            try
            {
                _logic.Update(eEmployee);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE: api/Suppliers/{id}
        [ResponseType(typeof(EmployeesView))]
        public IHttpActionResult DeleteEmployee(int id)
        {
            var eEmployee = _logic.GetEmployeeByID(id);

            if (eEmployee == null)
            {
                return NotFound();
            }

            try
            {
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