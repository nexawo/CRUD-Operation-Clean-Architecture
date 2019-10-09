using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.DynamicObjects.Commands.CreateModel
{
    public class CreateModelCommand :IRequest<bool>
    {
        public DynamicObjectDTO DynamicObjectDTO { get; set; }
    }
}
