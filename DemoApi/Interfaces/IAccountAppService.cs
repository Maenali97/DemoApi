namespace DemoApi
{
    public interface IAccountAppService
    {
        Task<LoginResponse> LoginAsync(LoginDto dto);
        Task<EmployeeDto> RegisterAsync(RegisterDto dto);
        Task<List<EmployeeDto>> GetEmployeeListAsync();
        Task<EmployeeDto> GetEmployeeByEmailAsync(string email);
        Task<List<EmployeeDto>> GetEmployeeListFilterAsync(EmployeeFilter filter);
    }
}
