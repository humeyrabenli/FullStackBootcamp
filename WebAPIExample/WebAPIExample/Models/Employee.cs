using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIExample.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Dateofbirth { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
        public string MaritalStatus { get; set; }
        public List<string> Properties { get; set; }


    }
}
