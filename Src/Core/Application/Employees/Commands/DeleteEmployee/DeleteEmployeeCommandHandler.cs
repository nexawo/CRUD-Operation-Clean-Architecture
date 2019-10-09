using MediatR;
using Nexawo.Application.Common.Exceptions;
using Nexawo.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.Employees.Commands.DeleteEmployee
{
    public class DeleteEmployeeCommandHandler :IRequestHandler<DeleteEmployeeCommand>
    {
        private readonly IMainDbContext _context;

        public DeleteEmployeeCommandHandler(IMainDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var Entity = await _context.Employees.FindAsync(request.EmployeeId);

            if (Entity == null)
            {
                throw new NotFoundException(nameof(Employees), request.EmployeeId);
            }

            _context.Employees.Remove(Entity);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
