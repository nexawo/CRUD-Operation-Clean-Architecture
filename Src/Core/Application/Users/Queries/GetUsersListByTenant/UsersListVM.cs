using Microsoft.AspNetCore.Mvc.Rendering;
using Nexawo.Application.Tenants.Queries.GetTenantDetail;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Users.Queries.GetUsersListByTenant
{
    public class UsersListVM
    {
       public TenantDetailVM Tenant { get; set; }
        public IList<UserDTO> Users { get; set; }        
    }
}
