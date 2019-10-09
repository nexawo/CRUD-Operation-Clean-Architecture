using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexawo.Domain.Entities.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Persistence.Configurations
{
    public class ServiceConfiguratoin : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.Property(prop => prop.Id)
                   .IsRequired(true)
                   .ValueGeneratedOnAdd();
            builder.Property(prop => prop.Name)
                   .IsRequired(true).HasMaxLength(50);
        }
    }
}
