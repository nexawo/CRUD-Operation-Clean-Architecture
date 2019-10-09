using MediatR;
using Nexawo.Application.DynamicObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.DynamicObjects.Commands.CreateController
{
    public class CreateControllerCommand :IRequest<bool>
    {
        public DynamicObjectDTO DynamicObjectDTO { get; set; }
    }
}
