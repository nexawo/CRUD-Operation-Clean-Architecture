using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Nexawo.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.Tenants.Queries.GetTenantsList
{
    public class GetTenantsListQueryHandler : IRequestHandler<GetTenantsListQuery, TenantsListVM>
    {
        private readonly IMainDbContext _context;
        private readonly IMapper _mapper;

        public GetTenantsListQueryHandler(IMainDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<TenantsListVM> Handle(GetTenantsListQuery request, CancellationToken cancellationToken)
        {
            var tenants = await _context.Tenants
                .ProjectTo<TenantDTO>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            var vm = new TenantsListVM
            {
                Tenants = tenants
            };

            return vm;
        }
    }
}
