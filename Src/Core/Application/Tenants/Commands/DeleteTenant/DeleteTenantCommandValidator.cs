using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Tenants.Commands.DeleteTenant
{
    public class DeleteTenantCommandValidator : AbstractValidator<DeleteTenantCommand>
    {
        public DeleteTenantCommandValidator()
        {
            RuleFor(x => x.Id).MinimumLength(2).NotEmpty();
        }
    }
}
