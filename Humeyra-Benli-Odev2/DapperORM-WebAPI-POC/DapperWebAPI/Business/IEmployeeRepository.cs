using DapperWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperWebAPI.Business
{
    public interface IEmployeeRepository:IRepository<Employee>
    {
    }
}
