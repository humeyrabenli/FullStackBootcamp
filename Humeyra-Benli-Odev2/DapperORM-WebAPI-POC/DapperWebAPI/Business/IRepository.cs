using DapperWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperWebAPI.Business
{
    public interface IRepository<T> where T : IEntity, new()
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);
    }
}
