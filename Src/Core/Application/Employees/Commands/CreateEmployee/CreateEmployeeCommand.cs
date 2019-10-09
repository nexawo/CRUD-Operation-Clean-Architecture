using MediatR;
using Nexawo.Application.Employees.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Employee.Commands.Create_Employee
{
    public class CreateEmployeeCommand : IRequest<int>
    {
        public EmployeeDTO EmployeeDTO { get; set; }

    }
}
