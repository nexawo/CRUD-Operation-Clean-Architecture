using FluentValidation;
using Nexawo.Application.Employee.Commands.Create_Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Employees.Commands.Create_Employee
{
    public class CreateEmployeeCommandValidator : AbstractValidator<CreateEmployeeCommand>
    {
        public CreateEmployeeCommandValidator()
        {
            RuleFor(x => x.EmployeeDTO.FirstName).MaximumLength(50).NotEmpty();
            RuleFor(x => x.EmployeeDTO.LastName).MaximumLength(50).NotEmpty();
            RuleFor(x => x.EmployeeDTO.Email).MaximumLength(50);
            RuleFor(x => x.EmployeeDTO.Age).NotEmpty();
            RuleFor(x => x.EmployeeDTO.Address).MaximumLength(200).NotEmpty();

        }
        
    }
}
