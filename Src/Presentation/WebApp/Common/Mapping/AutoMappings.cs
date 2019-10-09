using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace WebApp.Common.Mapping
{
    public static class AutoMappings
    {
        public static void InitializeAutoMapper(this IServiceCollection services)
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(config =>
            {
                config.AddProfile<WebApp.Common.Mapping.MappingProfile>();
                config.AddProfile<Nexawo.Application.Common.Mapping.MappingProfile>();
                
            });
            IMapper mapper = mapperConfiguration.CreateMapper();
            //Mapper.AssertConfigurationIsValid();
            services.AddSingleton(mapper);
        }
    }
}
