using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.DynamicObjects.Commands.CreateView
{
    public class CreateViewCommand : IRequest<bool>
    {
        public DynamicObjectDTO DynamicObjectDTO { get; set; }
    }
}
