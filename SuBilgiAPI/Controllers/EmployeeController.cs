using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SuBilgiAPI.Models;
using SuBilgiAPI.Models.Interfaces;
using SuBilgiAPI.Models.Repositories;
using System.Collections.Generic;

namespace SuBilgiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        SuBilgiDBContext _context = new SuBilgiDBContext();

        private readonly EmployeeRepository _employeeRepository;


        public EmployeeController()
        {
            _employeeRepository = new EmployeeRepository(_context);
        }
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAllEmployee()
        {

         IEnumerable<Employee> employees1 = _employeeRepository.GetAllEmployees();
            return new ActionResult<IEnumerable<Employee>>(employees1);
        }
        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployee(int id)
        {
            var employee = _employeeRepository.GetEmployee(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
    }
}
