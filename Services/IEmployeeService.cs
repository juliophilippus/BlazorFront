using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFront.Models;

namespace BlazorFront.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAll();

        Task<Employee> GetById(int id);
    }
}