using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace DemoApi
{
    public class EmployeeRepository : Repository<Employee, Guid>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public EmployeeRepository(ApplicationDbContext dbContext) : base(dbContext) => _dbContext = dbContext;

        public Employee FindByEmail(string email)
        {
            return _dbContext.Employees.Where(x => x.Email == email).SingleOrDefault();

        }

        public Employee GetEmployeeByEmailAndPassword(string email, string password)
        {
            return  _dbContext.Employees.Where(x => x.Email == email && x.Password == password).SingleOrDefault();
            
        }

        public Employee GetEmployeeByEmailAsync(string email)
        {
            return  _dbContext.Employees.Where(x => x.Email == email).SingleOrDefault();
            
        }

        public async Task<List<Employee>> GetEmployeeListFilterAsync(EmployeeFilter filter)
        {
            return await Query()
                .WhereIf(!string.IsNullOrEmpty(filter.Name), x => filter.lang == "en" ? x.FirstNameEn.Contains(filter.Name) : x.FirstNameAr.Contains(filter.Name))
                .WhereIf(!string.IsNullOrEmpty(filter.Email), x => x.Email == filter.Email)
                .WhereIf(filter.IsCitizen != null, x => x.IsCitizen == filter.IsCitizen)
                .WhereIf(filter.Gender != null, x => x.Gender == filter.Gender)
                .OrderBy(x => x.CreationDate)
                .PageBy((filter.Skip - 1) * filter.Size, filter.Size)
                .ToListAsync();
        }
    }
}
