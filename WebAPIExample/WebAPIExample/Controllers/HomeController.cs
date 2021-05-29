using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIExample.Business;
using WebAPIExample.Models;

namespace WebAPIExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        public IActionResult AllProducts()
        {
            EmployeeService dataService = new EmployeeService();
            var list = dataService.GetListResponseDTOs();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            EmployeeService dataService = new EmployeeService();
            var employee = dataService.GetEmployeeResponseDto(id);
            if (employee==null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            return CreatedAtAction(nameof(GetEmployeeById), new { id = 3 }, null);
        }


    }
}
