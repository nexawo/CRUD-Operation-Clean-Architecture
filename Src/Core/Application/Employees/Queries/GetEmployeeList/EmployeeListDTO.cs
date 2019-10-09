using AutoMapper;
using Nexawo.Application.Common.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Employees.Queries.GetEmployeeList
{
    public class EmployeeListDTO : IMapFrom<Nexawo.Domain.Entities.Main.Employee>
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CNIC { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Nexawo.Domain.Entities.Main.Employee, EmployeeListDTO>()
                .ForMember(d => d.EmployeeId, opt => opt.MapFrom(s => s.EmployeeId))
                .ForMember(d => d.FirstName, opt => opt.MapFrom(s => s.FirstName))
                .ForMember(d => d.LastName, opt => opt.MapFrom(s => s.LastName))
                .ForMember(d => d.Email, opt => opt.MapFrom(s => s.Email))
                .ForMember(d => d.Age, opt => opt.MapFrom(s => s.Age))
                .ForMember(d => d.Address, opt => opt.MapFrom(s => s.Address));
        }
    }
}
