using AutoMapper;
using Nexawo.Application.Common.Mapping;
using Nexawo.Domain.Entities.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Tenants.Queries.GetTenantDetail
{
    public class TenantDetailVM : IMapFrom<Nexawo.Domain.Entities.Main.Tenant>
    {
        public string TenantId { get; set; }
        public string Name { get; set; }
        public string DBConnection { get; set; }
        public virtual List<Users.Queries.GetUsersListByTenant.UserDTO> Users { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Tenant, TenantDetailVM>()
                .ForMember(d => d.TenantId, opt => opt.MapFrom(s => s.TenantId))
                .ForMember(d => d.Users, opt => opt.MapFrom(s => s.Users));
        }
    }
}