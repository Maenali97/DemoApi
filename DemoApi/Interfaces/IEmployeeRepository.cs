using Domain;

namespace DemoApi
{
    public interface IEmployeeRepository : IRepository<Employee, Guid>
    {
        Employee FindByEmail(string email);
        Employee GetEmployeeByEmailAndPassword(string email, string password);
    }
}
