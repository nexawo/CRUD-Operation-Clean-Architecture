using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nexawo.Application.Common.Mapping;
using Nexawo.Domain.Entities.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Users.Queries.GetUsersListByTenant
{
    public class UserDTO : IMapFrom<User>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<User, UserDTO>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.Name))
                .ForMember(d => d.Email, opt => opt.MapFrom(s => s.Email))            
            ;            

        }
        
    }
}
