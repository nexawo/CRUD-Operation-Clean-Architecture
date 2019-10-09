using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Employees.Queries.GetEmployeeList
{
    public class GetEmployeeListQuery : IRequest<EmployeeListVM>
    {
        public int Employeeid { get; set; }
    }
}
