using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Services.Commands.CreateCommand
{
    public class CreateServiceCommandValidator : AbstractValidator<CreateServiceCommand>
    {
        public CreateServiceCommandValidator()
        {            
            RuleFor(x => x.ServiceDTO.Name).MaximumLength(50).NotEmpty();
            RuleFor(x => x.ServiceDTO.Description).MaximumLength(100).NotEmpty();
        }
    }
}
