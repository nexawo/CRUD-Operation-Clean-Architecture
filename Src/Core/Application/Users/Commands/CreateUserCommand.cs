using MediatR;
using Nexawo.Application.Users.Queries.GetUsersListByTenant;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Users.Commands
{
    public class CreateUserCommand : IRequest<int>
    {
        public UserDTO UserDTO { get; set; }
    }
}
