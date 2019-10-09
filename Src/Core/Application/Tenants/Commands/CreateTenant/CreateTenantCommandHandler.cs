using Nexawo.Domain.Entities.Main;
using MediatR;
using Nexawo.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.Tenants.Commands.CreateTenant
{
    public class CreateTenantCommandHandler : IRequestHandler<CreateTenantCommand,int>
    {
        private readonly IMainDbContext _context;
        private readonly IMediator _mediator;

        public CreateTenantCommandHandler(IMainDbContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<int> Handle(CreateTenantCommand request, CancellationToken cancellationToken)
        {
            var entity = new Tenant
            {
                TenantId = request.TenantId,
                Name = request.Name,
                DBConnection = request.DBConnection
            };

            _context.Tenants.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new TenantCreated { TenantId = entity.TenantId }, cancellationToken);

            return 1;
        }
    }
}
