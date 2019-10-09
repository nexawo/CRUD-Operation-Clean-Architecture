using AutoMapper;
using MediatR;
using Nexawo.Application.Common.Exceptions;
using Nexawo.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.Tenants.Queries.GetTenantDetail
{
    public class GetTenantDetailQueryHandler : IRequestHandler<GetTenantDetailQuery, TenantDetailVM>
    {
        private readonly IMainDbContext _context;
        private readonly IMapper _mapper;

        public GetTenantDetailQueryHandler(IMainDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<TenantDetailVM> Handle(GetTenantDetailQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Tenants
                .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Tenants), request.Id);
            }

            return _mapper.Map<TenantDetailVM>(entity);
        }
    }
}
