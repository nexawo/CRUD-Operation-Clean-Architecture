using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Tenants.Queries.GetTenantsList
{
    public class GetTenantsListQuery : IRequest<TenantsListVM>
    {
    }
}
