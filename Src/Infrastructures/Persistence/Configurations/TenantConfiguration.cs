using Nexawo.Domain.Entities.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Persistence.Configurations
{
    public class TenantConfiguration : IEntityTypeConfiguration<Tenant>
    {
        public void Configure(EntityTypeBuilder<Tenant> builder)
        {
            builder.Property(e => e.TenantId)
                   .HasMaxLength(50)
                   .ValueGeneratedOnAdd();                        
            builder.Property(e => e.Name).IsRequired().HasMaxLength(50);
            builder.Property(e => e.DBConnection).IsRequired().HasMaxLength(50);

            builder.HasMany(user => user.Users).WithOne();
        }
    }
}
