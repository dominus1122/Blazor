using CrudDemo.Models;

namespace CrudDemo.Services
{
    public interface IEmployeeService
    {
        public Task<List<Employee>> GetEmployeesAsync();
        public Task<Employee> GetEmployeeByIdAsync(int id);
        public Task<Employee> CreateEmployeeAsync(Employee employee);
        public Task UpdateEmployeeAsync(Employee employee);
        public Task DeleteEmployeeAsync(int id);

    }
}
