using AutoMapper;
using MediatR;
using Nexawo.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.Referral.Commands.CreateReferral
{
    public class CreateReferralCommandHandler : IRequestHandler<CreateReferralCommand, int>
    {
        private readonly IMainDbContext _context;
        private readonly IMapper _mapper;
        public CreateReferralCommandHandler(IMainDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateReferralCommand request, CancellationToken cancellationToken)
        {
            Nexawo.Domain.Entities.Main.Referral referral = _mapper.Map<Nexawo.Domain.Entities.Main.Referral>(request.ReferralDTO);            
            _context.Referrals.Add(referral);
            int result = await _context.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}
