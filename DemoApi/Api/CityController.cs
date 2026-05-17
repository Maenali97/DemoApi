using Microsoft.AspNetCore.Mvc;

namespace DemoApi
{
    [Route("api/city")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityRepository _repository;

        public CityController(ICityRepository repository) => _repository = repository;
        

        [HttpGet("getcities")]
        public async Task<IActionResult> GetListAsync() => Ok(await _repository.GetListAsync());

        [HttpGet("getcitiesbycountryid")]
        public async Task<IActionResult> GetCitiesByCountryId(Guid countryId) => Ok(await _repository.GetCitiesByCountryId(countryId));
    }
}
