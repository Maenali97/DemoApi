using Domain;

namespace DemoApi
{
    public static class ProgramExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IAccountAppService, AccountAppService>();
            services.AddScoped<ICityAppService, CityAppService>();
            services.AddScoped<ICountryAppService, CountryAppService>();

            return services;

        }
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();

            return services;

        }
    }
}
