using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexawo.Domain.Entities.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Persistence.Configurations
{
    public class ReferralConfiguration : IEntityTypeConfiguration<Referral>
    {
        public void Configure(EntityTypeBuilder<Referral> builder)
        {
            builder.Property(prop => prop.Id)
                .IsRequired(true);
            builder.Property(prop => prop.ReferralDate).HasColumnType("datetime");
        }
    }
}
