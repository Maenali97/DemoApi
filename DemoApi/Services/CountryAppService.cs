using Admin;

namespace DemoApi
{
    public class CountryAppService : ICountryAppService
    {
        private readonly ICountryRepository _service;

        public CountryAppService(ICountryRepository service) => _service = service;

        public async Task<List<CountryDto>> GetListAsync()
        {
            return ObjectMapper.Map<List<Country>, List<CountryDto>>(await _service.GetListAsync());
        }
    }
}
