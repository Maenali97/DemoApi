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

        public async Task<EmployeeDto> RegisterAsync(RegisterDto dto)
        {
            var entity = new Employee(
                id:Guid.NewGuid(),dto.Email,
                dto.Password,dto.FirstNameEn,
                dto.SecondNameEn,dto.ThirdNameEn,
                dto.LastNameEn,dto.FirstNameAr,
                dto.SecondNameAr,dto.ThirdNameAr,
                dto.LastNameAr,dto.DateOfBirth,
                dto.Gender,dto.MaritalStatus,
                dto.NationalNumber,dto.PhoneNumber
                );

            entity.CreationDate  = DateTime.Now;

           await _employeeRepository.InsertAsync(entity);

            return ObjectMapper.Map<Employee,EmployeeDto>(entity);
        }

        public async Task<List<EmployeeDto>> GetEmployeeListAsync()
        {

            var employees = await _employeeRepository.GetListAsync();

            return ObjectMapper.Map<List<Employee>, List<EmployeeDto>>(employees);

        }

        public async Task<EmployeeDto> GetEmployeeByEmailAsync(string email)
        {

            var employee =  _employeeRepository.GetEmployeeByEmailAsync(email);

            return ObjectMapper.Map<Employee, EmployeeDto>(employee);

        }

        public async Task<List<EmployeeDto>> GetEmployeeListFilterAsync(EmployeeFilter filter)
        {

            var employees = await _employeeRepository.GetEmployeeListFilterAsync(filter);

            return ObjectMapper.Map<List<Employee>, List<EmployeeDto>>(employees);

        }

    }
}
