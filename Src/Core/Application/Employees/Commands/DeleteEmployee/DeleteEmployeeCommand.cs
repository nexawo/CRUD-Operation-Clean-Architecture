using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Employees.Commands.DeleteEmployee
{
    public class DeleteEmployeeCommand : IRequest
    {
        public int EmployeeId { get; set; }
    }
}
