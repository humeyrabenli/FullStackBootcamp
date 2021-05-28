using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIExample.Models;

namespace WebAPIExample.Business
{
    public class EmployeeRepository
    {
        public List<Employee> GetAllEmployees() 
        {
          List<Employee> employees = new List<Employee>() {
            new Employee
            {
                Id=1,
                Name="Ayşe",
                Surname="Yılmaz",
                Dateofbirth=new DateTime(1995,1,2),
                Department="Ekonomi",
                Salary=4200,
                MaritalStatus="Evli"
            },

            new Employee
            {
                Id=2,
                Name="Ali",
                Surname="Yıldız",
                Dateofbirth=new DateTime(1992,6,4),
                Department="Bilgisayar",
                Salary=4500,
                MaritalStatus="Bekar"
            },
          };
            
            employees.Add(new Employee
            {
                Id = 3,
                Name = "Elif",
                Surname = "Türk",
                Dateofbirth = new DateTime(1994, 2, 3),
                Department = "İnsan Kaynakları",
                Salary = 4000,
                MaritalStatus = "Bekar"
            });

            return employees;
        }

    }
}
