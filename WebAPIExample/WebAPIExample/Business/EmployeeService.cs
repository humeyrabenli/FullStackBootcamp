using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIExample.Models;

namespace WebAPIExample.Business
{
    public class EmployeeService
    {
        public List<EmployeeListResponseDTO> GetListResponseDTOs() 
        {
            EmployeeRepository repo = new EmployeeRepository();
            var employees = repo.GetAllEmployees();

            List<EmployeeListResponseDTO> dtoList = new List<EmployeeListResponseDTO>();

            foreach (var employee in employees)
            {
                var dto = new EmployeeListResponseDTO
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Surname = employee.Surname,
                    Department = employee.Department,
                    MaritalStatus = employee.MaritalStatus
                };
                dtoList.Add(dto);

            }
            return dtoList;
        
        
        }

        public Employee GetEmployeeResponseDto(int id)
        {
            EmployeeRepository repo = new EmployeeRepository();
            var employees = repo.GetAllEmployees();
            return employees.FirstOrDefault(e => e.Id == id);
        }
        
        
    }
}
