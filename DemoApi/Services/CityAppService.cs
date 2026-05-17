using Admin;

namespace DemoApi
{
    public class CityAppService : ICityAppService
    {
        private readonly ICityRepository _service;

        public CityAppService(ICityRepository service) => _service = service;

        public async Task<List<CityDto>> GetListAsync()
        {
            return ObjectMapper.Map<List<City>, List<CityDto>>(await _service.GetListAsync());
        }

    }
}
