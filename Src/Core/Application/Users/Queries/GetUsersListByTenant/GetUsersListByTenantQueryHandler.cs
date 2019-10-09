using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Nexawo.Application.Common.Interfaces;
using Nexawo.Application.Tenants.Queries.GetTenantDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.Users.Queries.GetUsersListByTenant
{
    public class GetUsersListByTenantQueryHandler : IRequestHandler<GetUsersListByTenantQuery, TenantDetailVM>
    {
        private readonly IMainDbContext _context;
        private readonly IMapper _mapper;
        public GetUsersListByTenantQueryHandler(IMainDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<TenantDetailVM> Handle(GetUsersListByTenantQuery request, CancellationToken cancellationToken)
        {
            //var tenantUsers = await _context.Tenants.Where(tenant => tenant.TenantId == request.TenantId)
            //     .Include(user => user.Users)         
            //     .FirstOrDefaultAsync(cancellationToken);
            //var tenant = _mapper.Map<Nexawo.Application.Tenants.Queries.GetTenantDetail.TenantDetailVM>(tenantUsers);            
            //var users = _mapper.Map<List<UserDTO>>(tenantUsers.Users.ToList());
            var tenantUsers = await _context.Tenants.Where(tenant => tenant.TenantId == request.TenantId)
              .ProjectTo<TenantDetailVM>(_mapper.ConfigurationProvider)
              .FirstOrDefaultAsync();
            
            //var vm = new UsersListVM
            //{
            //    Users = tenantUsers.,
            //    Tenant = tenant
            //};
            return tenantUsers;
        }
      
    }
}
