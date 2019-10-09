using MediatR;
using Nexawo.Application.Tenants.Queries.GetTenantDetail;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Users.Queries.GetUsersListByTenant
{
    public class GetUsersListByTenantQuery:IRequest<TenantDetailVM>
    {
        public string TenantId { get; set; }
    }
}
