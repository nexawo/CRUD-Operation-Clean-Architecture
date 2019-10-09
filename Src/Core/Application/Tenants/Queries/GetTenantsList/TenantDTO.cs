using AutoMapper;
using Nexawo.Domain.Entities.Main;
using Nexawo.Application.Common.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Tenants.Queries.GetTenantsList
{
    public class TenantDTO : IMapFrom<Tenant>
    {
        public string TenantId { get; set; }
        public string Name { get; set; }
        public string DBConnection { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Tenant, TenantDTO>()
                .ForMember(d => d.TenantId, opt => opt.MapFrom(s => s.TenantId))
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.Name))
                .ForMember(d => d.DBConnection, opt => opt.MapFrom(s => s.DBConnection));
        }
    }
}
