using AutoMapper;
using Nexawo.Application.Common.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Nexawo.Application.Employees.Queries.GetEmployeeDetail
{
   public  class EmployeeDetailVM : IMapFrom<Nexawo.Domain.Entities.Main.Employee>
    {
        public int EmployeeId { get; set; }
        [DisplayName("First Name:")]
        public string FirstName { get; set; }
        [DisplayName("Last Name:")]
        public string LastName { get; set; }
        [DisplayName("CNIC:")]
        public string CNIC { get; set; }
        
        [DisplayName("Email:")]
        public string Email { get; set; }

        [DisplayName("Age:")]
        public int Age { get; set; }

        [DisplayName("Address:")]
        public string Address { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Nexawo.Domain.Entities.Main.Employee, EmployeeDetailVM>()
                .ForMember(d => d.EmployeeId, opt => opt.MapFrom(s => s.EmployeeId));
        }
    }
}
