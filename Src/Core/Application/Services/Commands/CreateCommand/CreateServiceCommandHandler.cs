using AutoMapper;
using MediatR;
using Nexawo.Application.Common.Interfaces;
using Nexawo.Domain.Entities.Main;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.Services.Commands.CreateCommand
{
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand, int>
    {
        private readonly IMainDbContext _context;
        private readonly IMapper _mapper;
        public CreateServiceCommandHandler(IMainDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            var service = _mapper.Map<Service>(request.ServiceDTO);
            _context.Services.Add(service);
            int result = await _context.SaveChangesAsync(cancellationToken);
            return result;


        }
    }
}
