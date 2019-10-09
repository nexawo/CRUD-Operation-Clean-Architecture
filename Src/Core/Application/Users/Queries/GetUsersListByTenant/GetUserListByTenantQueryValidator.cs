using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Users.Queries.GetUsersListByTenant
{
    public class GetUserListByTenantQueryValidator : AbstractValidator<GetUsersListByTenantQuery>
    {
        public GetUserListByTenantQueryValidator()
        {
            RuleFor(r => r.TenantId).NotEmpty();
        }
    }
}
