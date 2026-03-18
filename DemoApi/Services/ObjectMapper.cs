using AutoMapper;
using DemoApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    public static class ObjectMapper
    {
        private static readonly IMapper _mapper;

        static ObjectMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Add all your mappings here
                cfg.AddProfile<AutoMapperProfile>();
            });

            _mapper = config.CreateMapper();
        }

        public static TDestination Map<TSource, TDestination>(TSource source)
        {
            return _mapper.Map<TSource, TDestination>(source);
        }
    }
}
