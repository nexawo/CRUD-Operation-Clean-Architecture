using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Tenants.Queries.GetTenantDetail
{
    public class GetTenantDetailQueryValidator : AbstractValidator<GetTenantDetailQuery>
    {
        public GetTenantDetailQueryValidator()
        {
            RuleFor(v => v.Id).NotEmpty().MaximumLength(50);
        }
    }
}
