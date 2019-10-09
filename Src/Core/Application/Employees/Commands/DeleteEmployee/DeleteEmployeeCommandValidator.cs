using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace Nexawo.Application.Employees.Commands.DeleteEmployee
{
    public class DeleteEmployeeCommandValidator :AbstractValidator<DeleteEmployeeCommand>
    {
        public DeleteEmployeeCommandValidator()
        {
            //RuleFor(x => x.EmployeeId).NotEmpty();
        }
    }
}
