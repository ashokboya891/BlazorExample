using EmployeeBlazor.Models;

namespace EmployeeBlazor.Servcies
{
    public class EmployeeService
    {
        private readonly HttpClient _http;

        public EmployeeService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Employee>> GetEmployees() =>
            await _http.GetFromJsonAsync<List<Employee>>("api/employees");

        public async Task CreateEmployee(Employee emp) =>
            await _http.PostAsJsonAsync("api/employees", emp);

        public async Task UpdateEmployee(Employee emp) =>
            await _http.PutAsJsonAsync($"api/employees/{emp.Id}", emp);

        public async Task DeleteEmployee(int id) =>
            await _http.DeleteAsync($"api/employees/{id}");
    }
}
