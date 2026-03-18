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

    }
}
