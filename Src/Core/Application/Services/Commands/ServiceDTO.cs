using AutoMapper;
using Nexawo.Application.Common.Mapping;
using Nexawo.Domain.Entities.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Services.Commands
{
    public class ServiceDTO : IMapFrom<Service>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public ICollection<User> Users { get; private set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Nexawo.Domain.Entities.Main.Service, ServiceDTO>();
            //.ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
            //.ForMember(d => d.Name, opt => opt.MapFrom(s => s.Name))
            //.ForMember(d => d.Email, opt => opt.MapFrom(s => s.Email));
        
        }


    }
}
