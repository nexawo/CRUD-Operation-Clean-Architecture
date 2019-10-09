using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Tenants.Commands.UpdateTenant
{
    public class UpdateTenantCommandValidator : AbstractValidator<UpdateTenantCommand>
    {
        public UpdateTenantCommandValidator()
        {
            RuleFor(x => x.TenantId).NotEmpty();
            RuleFor(x => x.Name).MaximumLength(50).NotEmpty();
            RuleFor(x => x.DBConnection).MaximumLength(50).NotEmpty();
        }
    }
}
