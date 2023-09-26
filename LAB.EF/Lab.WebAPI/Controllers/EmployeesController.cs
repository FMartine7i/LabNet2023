using Lab.EF.Entities;
using Lab.EF.Entities.DTOs;
using Lab.EF.Logic;
using Lab.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Cors;

namespace Lab.WebAPI.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers:"*", methods:"GET, POST, PUT, DELETE, OPTIONS")]
    public class EmployeesController : ApiController
    {
        // GET: api/Employees
        public IHttpActionResult GetEmployees()
        {
            try
            {
                var employeesLogic = new EmployeesLogic();

                List<EmployeesDTO> employeesViews = employeesLogic.GetAll();


                return Ok(employeesViews);
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
                var employees = new EmployeesLogic();
                var employee = employees.GetEmployeeByID(ID);

                if (employee == null)
                {
                    return NotFound();
                }

                EmployeesView eView = new EmployeesView
                {
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    City = employee.City,
                    Country = employee.Country
                };

                return Ok(eView);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // POST: api/Employees
        [ResponseType(typeof(EmployeesDTO))]
        public IHttpActionResult PostEmployee(EmployeesDTO employeesDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try 
            {
                EmployeesLogic employeesLogic = new EmployeesLogic();
                var newEmployee = employeesLogic.Add(employeesDTO);

                return CreatedAtRoute("DefaultApi", new { id = newEmployee.EmployeeID }, newEmployee);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }            
        }

        // PUT: api/Employees/{id}
        [ResponseType(typeof(void))]
        public IHttpActionResult UpdateEmployee(int id, EmployeesDTO employee)
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
                EmployeesLogic employeesLogic = new EmployeesLogic();
                var eEmployee = employeesLogic.GetEmployeeByID(id);

                if (eEmployee == null)
                {
                    return NotFound();
                }

                eEmployee.FirstName = employee.FirstName;
                eEmployee.LastName = employee.LastName;
                eEmployee.City = employee.City;
                eEmployee.Country = employee.Country;

                employeesLogic.Update(eEmployee);
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
                var eEmployee = new EmployeesLogic();

                if (eEmployee == null)
                {
                    return NotFound();
                }

                eEmployee.Delete(id);
                return Ok("Employee deleted");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}