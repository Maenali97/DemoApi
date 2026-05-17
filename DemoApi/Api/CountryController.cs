using Microsoft.AspNetCore.Mvc;

namespace DemoApi
{
    [Route("api/country")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _repository;

        public CountryController(ICountryRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("getcountries")]
        public async Task<IActionResult> RegisterAsync() => Ok(await _repository.GetListAsync());
    }
}
