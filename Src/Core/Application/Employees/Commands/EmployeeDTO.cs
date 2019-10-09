using AutoMapper;
using Nexawo.Application.Employees.Queries.GetEmployeeList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Nexawo.Application.Employees.Commands
{
    public class EmployeeDTO
    {
        [DisplayName("ID")]
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
            profile.CreateMap<Nexawo.Domain.Entities.Main.Employee, EmployeeDTO>();
           
        }

        public static implicit operator EmployeeDTO(Queries.GetEmployeeList.EmployeeListDTO v)
        {
            throw new NotImplementedException();
        }
    }
}
