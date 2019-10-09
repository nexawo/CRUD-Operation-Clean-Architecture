using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexawo.Domain.Entities.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>        
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Email).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Password).IsRequired().HasMaxLength(50);

            builder.HasOne(tenant => tenant.Tenant)
                   .WithMany(user => user.Users);
                   //.HasForeignKey(;
        }
    }
}
