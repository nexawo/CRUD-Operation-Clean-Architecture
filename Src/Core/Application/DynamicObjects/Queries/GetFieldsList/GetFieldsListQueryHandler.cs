
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Nexawo.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.DynamicObjects.Queries.GetFieldsList
{
    public class GetFieldsListQueryHandler : IRequestHandler<GetFieldsListQuery, FieldsListViewModel>
    {
        private readonly IMainDbContext _context;        
        private readonly IMapper _mapper;
        public GetFieldsListQueryHandler(IMainDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<FieldsListViewModel> Handle(GetFieldsListQuery request, CancellationToken cancellationToken)
        {
            var serviceDetails = await _context.ServiceDetails
                                            .Where(row => row.Page == request.Page && row.Service == request.Service)
                                            .FirstOrDefaultAsync(cancellationToken);
            //var fields = _mapper.Map<List<FieldsDetailDTO>>(serviceDetails.Content.ToList());
            var fields = JsonConvert.DeserializeObject<List<FieldsDetailDTO>>(serviceDetails.Content);
            var fieldsListViewModel = new FieldsListViewModel()
            {
                Fields = fields
            };
            return fieldsListViewModel;

            
        }
    }
}
