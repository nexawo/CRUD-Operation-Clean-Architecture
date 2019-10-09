using MediatR;
using Nexawo.Application.Common.Exceptions;
using Nexawo.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.Tenants.Commands.DeleteTenant
{
    public class DeleteTenantCommandHandler : IRequestHandler<DeleteTenantCommand>
    {
        private readonly IMainDbContext _context;

        public DeleteTenantCommandHandler(IMainDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteTenantCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Tenants.FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Tenants), request.Id);
            }
            //Un Comment below code if tenant users are created and user want to delete tenant it won't allow user to delete tenant
            //var hasOrders = _context.TenantUsers.Any(od => od.ProductId == entity.ProductId);
            //if (hasOrders)
            //{
            //    // TODO: Add functional test for this behaviour.
            //    throw new DeleteFailureException(nameof(Product), request.Id, "There are existing orders associated with this product.");
            //}

            _context.Tenants.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }

    }
}
