using Domain;

namespace DemoApi
{
    public interface ICountryRepository : IRepository<Country, Guid>
    {
    }
}
