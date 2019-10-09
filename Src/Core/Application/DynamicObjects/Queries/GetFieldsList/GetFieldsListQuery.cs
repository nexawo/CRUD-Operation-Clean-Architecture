using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.DynamicObjects.Queries.GetFieldsList
{
    public class GetFieldsListQuery : IRequest<FieldsListViewModel>
    {
        public string Page { get; set; }
        public string Service { get; set; }

    }
}
