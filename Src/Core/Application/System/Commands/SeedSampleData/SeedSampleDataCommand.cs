using MediatR;
using Nexawo.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.System.Commands.SeedSampleData
{
    public class SeedSampleDataCommand : IRequest
    {
    }

    public class SeedSampleDataCommandHandler : IRequestHandler<SeedSampleDataCommand>
    {
        private readonly IMainDbContext _context;
        //private readonly IUserManager _userManager;

        public SeedSampleDataCommandHandler(IMainDbContext context)//, IUserManager userManager)
        {
            _context = context;
            //_userManager = userManager;
        }

        public async Task<Unit> Handle(SeedSampleDataCommand request, CancellationToken cancellationToken)
        {
            var seeder = new SampleDataSeeder(_context);//, _userManager);

            await seeder.SeedAllAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
