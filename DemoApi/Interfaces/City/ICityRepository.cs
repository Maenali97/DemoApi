using Domain;

namespace DemoApi
{
    public interface ICityRepository : IRepository<City, Guid>
    {
        Task<List<City>> GetCitiesByCountryId(Guid countryId);
    }
}
