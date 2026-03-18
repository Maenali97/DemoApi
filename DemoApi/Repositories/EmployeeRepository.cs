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
    }
}
