using Admin;
using Microsoft.AspNetCore.Identity;

namespace DemoApi
{
    public class AccountAppService : IAccountAppService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public AccountAppService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


        public async Task<LoginResponse> LoginAsync(LoginDto dto)
        {
            var response = new LoginResponse();

            if (string.IsNullOrEmpty(dto.Email) || string.IsNullOrEmpty(dto.Password))
            {
                response.Message = "Email Or Password Not Provided";
                return response;
            }

            var employeebyEmail =  _employeeRepository.FindByEmail(dto.Email);

            if (employeebyEmail == null)
            {
                response.IsSuccessful = false;
                response.Message = "No Employee Register With This Email";
                return response;
            }

            var employee = _employeeRepository.GetEmployeeByEmailAndPassword(dto.Email, dto.Password);

            if (employee == null)
            {
                response.IsSuccessful = false;
                response.Message = "Email or passwoed not correct";
                return response;

            }

            response.IsSuccessful = true;
            response.Employee = ObjectMapper.Map<Employee, EmployeeDto>(employee); ;
            response.Message = "Login Succefuly";
            return response;

        }

    }
}
