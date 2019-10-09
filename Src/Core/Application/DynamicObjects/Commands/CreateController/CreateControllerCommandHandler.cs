using Nexawo.Application.Common.Interfaces.DynamicObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.DynamicObjects.Commands.CreateController
{
    public class CreateControllerCommandHandler : IRequestHandler<CreateControllerCommand, bool>
    {
        IDynamicControllerService _dynamicControllerService;
        public CreateControllerCommandHandler(IDynamicControllerService dynamicControllerService)
        {
            _dynamicControllerService = dynamicControllerService;
        }
        public async Task<bool> Handle(CreateControllerCommand request, CancellationToken cancellationToken)
        {
            bool isSuccess = await _dynamicControllerService.GenerateFile("Controllers", request.DynamicObjectDTO);
            if (isSuccess)
            {
                isSuccess = await _dynamicControllerService.AddRefernces("Controllers", request.DynamicObjectDTO);
                if (isSuccess)
                {
                    isSuccess = await _dynamicControllerService.Index("Controllers", request.DynamicObjectDTO);
                    if (isSuccess)
                    {
                        isSuccess = await _dynamicControllerService.Get("Controllers", request.DynamicObjectDTO);
                        if (isSuccess)
                        {
                            isSuccess = await _dynamicControllerService.Post("Controllers", request.DynamicObjectDTO);
                        }
                    }
                }
            }
            
            
            
            return isSuccess;
        }
    }
}
