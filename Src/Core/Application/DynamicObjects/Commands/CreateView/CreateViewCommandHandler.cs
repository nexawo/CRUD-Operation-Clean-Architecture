using MediatR;
using Newtonsoft.Json;
using Nexawo.Application.Common.Interfaces;
using Nexawo.Application.Common.Interfaces.DynamicObjects;
using Nexawo.Domain.Entities.Main;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.DynamicObjects.Commands.CreateView
{
    public class CreateViewCommandHandler : IRequestHandler<CreateViewCommand, bool>
    {
        private readonly IDynamicViewService _dynamicViewService;
        private readonly IMainDbContext _context;
        private readonly IMediator _mediator;
        public CreateViewCommandHandler(IDynamicViewService dynamicViewService,IMainDbContext context,IMediator mediator)
        {
            _dynamicViewService = dynamicViewService;
            _context = context;
            _mediator = mediator;
        }
        public async Task<bool> Handle(CreateViewCommand request, CancellationToken cancellationToken)
        {
            bool isSuccess = await _dynamicViewService.GenerateFile("Views", request.DynamicObjectDTO);
            if(isSuccess)
            {
                isSuccess = await _dynamicViewService.AddContent("Views", request.DynamicObjectDTO);
                if (isSuccess)
                {
                    ServiceDetail serviceDetail = GenerateServiceDetailObject(request.DynamicObjectDTO);
                    _context.ServiceDetails.Add(serviceDetail);
                    await _context.SaveChangesAsync(cancellationToken);
                }
            }
            return isSuccess;
        }
        private ServiceDetail GenerateServiceDetailObject(DynamicObjectDTO dynamicObjectDTO)
        {
            string content = JsonConvert.SerializeObject(dynamicObjectDTO.FieldsDetailDTO);
            var serviceDetail = new ServiceDetail();
            serviceDetail.Page = dynamicObjectDTO.Page;
            serviceDetail.Service = dynamicObjectDTO.Service;
            serviceDetail.Content = content;
            return serviceDetail;
        }
    }
}
