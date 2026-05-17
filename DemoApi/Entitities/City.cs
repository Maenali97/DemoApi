using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApi
{
    public  class City : Entity<Guid>
    {
        public  string CityAr { get; set; }
        public  string CityEn { get; set; }
        public  Guid CountryID { get; set; }

        public City(Guid id, string cityAr, string cityEn , Guid countryID)
        {
            Check.NotNullOrEmpty(id, nameof(id));
            Check.NotNullOrEmpty(cityAr, nameof(cityAr));
            Check.NotNullOrEmpty(cityEn, nameof(cityEn));
            Check.NotNullOrEmpty(countryID, nameof(countryID));

            Id = id;
            CityAr = cityAr;
            CityEn = cityEn;
            CountryID = countryID;

        }

    }
}
