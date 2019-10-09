using MediatR;
using Nexawo.Application.Common.Exceptions;
using Nexawo.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.Tenants.Commands.UpdateTenant
{
    public class UpdateTenantCommandHandler :IRequestHandler<UpdateTenantCommand>
    {
        private readonly IMainDbContext _context;

        public UpdateTenantCommandHandler(IMainDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateTenantCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Tenants.FindAsync(request.TenantId);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Tenants), request.TenantId);
            }

            entity.TenantId = request.TenantId;
            entity.Name = request.Name;
            entity.DBConnection = request.DBConnection;            
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
