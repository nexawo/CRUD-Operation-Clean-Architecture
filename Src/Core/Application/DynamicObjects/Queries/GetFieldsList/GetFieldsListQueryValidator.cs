using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.DynamicObjects.Queries.GetFieldsList
{
    public class GetFieldsListQueryValidator : AbstractValidator<GetFieldsListQuery>
    {
        public GetFieldsListQueryValidator()
        {
            RuleFor(r => r.Page).NotEmpty();
            RuleFor(r => r.Service).NotEmpty();
        }
    }
}
