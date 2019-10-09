using FluentValidation;
using Nexawo.Application.Employees.Commands.UpdateEmployee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Employees.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommandValidator : AbstractValidator<UpdateEmployeeCommand>
    {
        public UpdateEmployeeCommandValidator()
        {
            RuleFor(x => x.FirstName).MaximumLength(50).NotEmpty();
            RuleFor(x => x.LastName).MaximumLength(50).NotEmpty();
            RuleFor(x => x.Email).MaximumLength(50);
            RuleFor(x => x.Age).NotEmpty();
            RuleFor(x => x.Address).MaximumLength(200).NotEmpty();

        }
    }
}
