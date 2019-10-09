using MediatR;
using Nexawo.Application.Common.Interfaces.DynamicObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.DynamicObjects.Commands.CreateModel
{
    public class CreateModelCommandHandler : IRequestHandler<CreateModelCommand, bool>
    {
        private readonly IDynamicModelService _dynamicModelService;
        public CreateModelCommandHandler(IDynamicModelService dynamicModelService)
        {
            _dynamicModelService = dynamicModelService;
        }

        public async Task<bool> Handle(CreateModelCommand request, CancellationToken cancellationToken)
        {
            bool isSuccess;
            isSuccess = await _dynamicModelService.GenerateFile("Src\\Core\\Application\\"+request.DynamicObjectDTO.Page, request.DynamicObjectDTO);
            if(isSuccess)
            {
                isSuccess = await _dynamicModelService.AddContent("Src\\Core\\Application\\"+request.DynamicObjectDTO.Page, request.DynamicObjectDTO);
            }
            return isSuccess;
        }
    }
}
