using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountAppService _accountService;

        public AccountController(IAccountAppService accountService) => _accountService = accountService;

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginAsync(LoginDto dto)=> Ok(await _accountService.LoginAsync(dto));
        
        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync(RegisterDto dto) => Ok(await _accountService.RegisterAsync(dto));
        
        [HttpGet("getemployeelist")]
        public async Task<IActionResult> GetEmployeeListAsync() => Ok(await _accountService.GetEmployeeListAsync());
        
        [HttpGet("getemployeebyemail")]
        public async Task<IActionResult> GetEmployeeByEmailAsync(string email) => Ok(await _accountService.GetEmployeeByEmailAsync(email));
    }
}
