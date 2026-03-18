using Domain;
using System.Reflection.Metadata;

namespace DemoApi
{
    public interface IDepartmentRepository : IRepository<Department, Guid>
    {
    }
}
