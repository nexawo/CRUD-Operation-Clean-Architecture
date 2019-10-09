using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Nexawo.Application.Common.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ApplyMappingsFromAssembly(Assembly.GetExecutingAssembly());
            CreateMap<Nexawo.Application.Users.Queries.GetUsersListByTenant.UserDTO, Nexawo.Domain.Entities.Main.User>();
            CreateMap<Nexawo.Application.Referral.Commands.ReferralDTO, Nexawo.Domain.Entities.Main.Referral>();
            CreateMap<Nexawo.Application.Services.Commands.ServiceDTO, Nexawo.Domain.Entities.Main.Service>();
            CreateMap<Nexawo.Application.Employees.Commands.EmployeeDTO, Nexawo.Domain.Entities.Main.Employee>();
        }

        private void ApplyMappingsFromAssembly(Assembly assembly)
        {
            var types = assembly.GetExportedTypes()
                .Where(t => t.GetInterfaces().Any(i =>
                    i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<>)))
                .ToList();

            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);
                var methodInfo = type.GetMethod("Mapping");
                methodInfo?.Invoke(instance, new object[] { this });
            }
        }
    }
}
