using DapperWebAPI.Business;
using DapperWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly DapperEmployeeRepository dapperEmployeeRepository;
        public EmployeesController()
        {
            dapperEmployeeRepository = new DapperEmployeeRepository();
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return dapperEmployeeRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return dapperEmployeeRepository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody]Employee employee)
        {
            if (ModelState.IsValid)
            {
                dapperEmployeeRepository.Add(employee);

            }
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Employee employee)
        {
            employee.EmployeeId = id;
            if (ModelState.IsValid)
            {
                dapperEmployeeRepository.Update(employee);

            }

        }

        [HttpDelete]
        public void Delete(int id)
        {
            dapperEmployeeRepository.Delete(id);
        }


    }
}
