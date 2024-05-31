using Common.DomainModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices _services;
        public EmployeeController(IEmployeeServices employeeServices) 
        { 
        _services = employeeServices;
        }

        [HttpGet]
        public List<Employee> GetEmployees() 
        {
            var employees = _services.GetAll();
            return employees;
        }
    }
}
