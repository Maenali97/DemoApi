using System.Reflection.Metadata;

namespace DemoApi
{
    public class DepartmentRepository : Repository<Department, Guid>, IDepartmentRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public DepartmentRepository(ApplicationDbContext dbContext) : base(dbContext) => _dbContext = dbContext;
    }
}
