using Dapper;
using DapperWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DapperWebAPI.Business
{
    public class DapperEmployeeRepository : IEmployeeRepository
    {
        private string connectionString;
        public DapperEmployeeRepository()
        {
            connectionString = @"Data Source = (localdb)\mssqllocaldb; Initial Catalog = DapperAPI; Integrated Security = True";
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }

        public void Add(Employee entity)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = @"INSERT INTO Employees (FirstName,LastName,DateOfBirth,Department)
                 VALUES (@FirstName,@LastName,@DateOfBirth,@Department)";
                dbConnection.Open();
                dbConnection.Execute(query, entity);
                
            }
        }

        

        public void Delete(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = @"DELETE FROM Employees Where EmployeeId=@Id";
                dbConnection.Open();
                dbConnection.Execute(query, new { Id =id });

            }
        }

        public IEnumerable<Employee> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = @"Select * FROM Employees";
                dbConnection.Open();
                return dbConnection.Query<Employee>(query);

            }
        }

        public Employee GetById(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = @"Select * FROM Employees Where EmployeeId=@Id";
                dbConnection.Open();
                return dbConnection.Query<Employee>(query,new { Id = id }).FirstOrDefault();

            }
        }


        public void Update(Employee entity)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = @"Update Employees SET FirstName=@FirstName, LastName=@LastName,
                DateOfBirth=@DateOfBirth, Department=@Department Where EmployeeId=@EmployeeId";
                dbConnection.Open();
                dbConnection.Query(query, entity);

            }
        }
    }
}
