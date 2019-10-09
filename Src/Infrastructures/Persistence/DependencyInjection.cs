using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nexawo.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MainDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("MainDatabase")));

            services.AddScoped<IMainDbContext>(provider => provider.GetService<MainDbContext>());

            return services;
        }
    }
}
