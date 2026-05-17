using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApi
{
    public  class Country : Entity<Guid>
    {
        public  string CountryAr { get; set; }
        public  string CountryEn { get; set; }

        public Country(Guid id, string countryAr, string countryEn)
        {
            Check.NotNullOrEmpty(id, nameof(id));
            Check.NotNullOrEmpty(countryAr, nameof(countryAr));
            Check.NotNullOrEmpty(countryEn, nameof(countryEn));

            Id = id;
            CountryAr = countryAr;
            CountryEn = countryEn;

        }
    }
}
