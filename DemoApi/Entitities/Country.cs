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
    }
}
