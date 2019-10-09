using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Common.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            
            CreateMap<Nexawo.Application.Referral.Service1ReferralViewModel, Nexawo.Application.Referral.Commands.ReferralDTO>();
        }
    }
}
