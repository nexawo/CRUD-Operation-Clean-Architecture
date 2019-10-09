using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Nexawo.Application.Common.Interfaces;
using Nexawo.Application.Services.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace Nexawo.Application.Services.Queries.GetServicesList
{
    public class GetServicesListQueryHandler : IRequestHandler<GetServicesListQuery, ServicesListVM>
    {
        private readonly IMainDbContext _context;
        private readonly IMapper _mapper;
        public GetServicesListQueryHandler(IMainDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ServicesListVM> Handle(GetServicesListQuery request, CancellationToken cancellationToken)
        {
            var result = await _context.Services
                                       .ProjectTo<ServiceDTO>(_mapper.ConfigurationProvider)
                                       .ToListAsync(cancellationToken);
            var serviceListVM = new ServicesListVM()
            {
                Services = result
            };
            return serviceListVM;
        }
        
    }
}
