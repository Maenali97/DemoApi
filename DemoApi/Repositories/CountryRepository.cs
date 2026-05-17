namespace DemoApi
{
    public class CountryRepository : Repository<Country, Guid>, ICountryRepository
    {
        public CountryRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
