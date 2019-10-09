using MediatR;
using Nexawo.Application.Common.Exceptions;
using Nexawo.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.Employees.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand>
    {
        private readonly IMainDbContext _context;

        public UpdateEmployeeCommandHandler(IMainDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var Entity = await _context.Employees.FindAsync(request.EmployeeId);

            if (Entity == null)
            {
                throw new NotFoundException(nameof(Employees), request.EmployeeId);
            }

            Entity.EmployeeId = request.EmployeeId;
            Entity.FirstName = request.FirstName;
            Entity.LastName = request.LastName;
            Entity.CNIC = request.CNIC;
            Entity.Email = request.Email;
            Entity.Age = request.Age;
            Entity.Address = request.Address;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

            //Entity.EmployeeId = request.EmployeeId;
        }

    }
}
