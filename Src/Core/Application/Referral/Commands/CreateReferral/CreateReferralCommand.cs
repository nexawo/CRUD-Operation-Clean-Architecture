using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Referral.Commands.CreateReferral
{
    public class CreateReferralCommand : IRequest<int>
    {
       public ReferralDTO ReferralDTO { get; set; }
    }
}
