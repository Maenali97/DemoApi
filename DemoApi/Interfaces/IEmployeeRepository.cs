using Domain;

namespace DemoApi
{
    public interface IEmployeeRepository : IRepository<Employee, Guid>
    {
        Employee FindByEmail(string email);
        Employee GetEmployeeByEmailAndPassword(string email, string password);
        Employee GetEmployeeByEmailAsync(string email);
        Task<List<Employee>> GetEmployeeListFilterAsync(EmployeeFilter filter);
    }
}
