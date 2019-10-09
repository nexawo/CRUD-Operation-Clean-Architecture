using AutoMapper;
using MediatR;
using Nexawo.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.Users.Commands
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IMainDbContext _context;
        private readonly IMapper _mapper;
        public CreateUserCommandHandler(IMainDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            Nexawo.Domain.Entities.Main.User user = _mapper.Map<Nexawo.Domain.Entities.Main.User>(request.UserDTO);
            _context.Users.Add(user);
            int result = await _context.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}
