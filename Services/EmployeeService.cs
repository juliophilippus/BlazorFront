using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorFront.Models;

namespace BlazorFront.Services
{
    public class EmployeeService : IEmployeeService
    {
        private HttpClient _httpClient;
        
        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            var results = await _httpClient.GetFromJsonAsync<IEnumerable<Employee>>("api/Employees");
            return results;
        }

        public async Task<Employee> GetById(int id)
        {
            var results = await _httpClient.GetFromJsonAsync<Employee>($"api/Employees/{id}");
            return results;
        }

        public Task<Employee> Add(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> Update(int id, Employee employee)
        {
            throw new NotImplementedException();
        }


    }
}