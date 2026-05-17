using Microsoft.EntityFrameworkCore;

namespace DemoApi
{
    public class CityRepository : Repository<City, Guid>, ICityRepository
    {
        public CityRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<City>> GetCitiesByCountryId(Guid countryId)
        {
            return await Query().Where(x => x.CountryID == countryId).ToListAsync();
        }
    }
}
