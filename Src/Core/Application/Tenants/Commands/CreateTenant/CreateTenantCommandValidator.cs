using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Tenants.Commands.CreateTenant
{
    public class CreateTenantCommandValidator : AbstractValidator<CreateTenantCommand>
    {
        public CreateTenantCommandValidator()
        {
            RuleFor(x => x.TenantId).MaximumLength(50).NotEmpty();
            RuleFor(x => x.Name).MaximumLength(50).NotEmpty();
            RuleFor(x => x.DBConnection).MaximumLength(50).NotEmpty();
        }
    }
}
