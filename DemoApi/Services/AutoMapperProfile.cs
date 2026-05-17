
using AutoMapper;

namespace DemoApi
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeDto, Employee>();

            CreateMap<City,CityDto>();
            CreateMap<CityDto, City>();

            CreateMap<Country, CountryDto>();
            CreateMap<CountryDto, Country>();
        }
    }
}
