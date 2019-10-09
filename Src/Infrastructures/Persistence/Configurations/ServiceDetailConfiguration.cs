using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexawo.Domain.Entities.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Persistence.Configurations
{
    public class ServiceDetailConfiguration : IEntityTypeConfiguration<ServiceDetail>
    {
        public void Configure(EntityTypeBuilder<ServiceDetail> builder)
        {
            builder.Property(prop => prop.Id)
                .IsRequired(true)
                .ValueGeneratedOnAdd();
            builder.Property(prop => prop.Service)
                .IsRequired(true)
                .HasMaxLength(50);
            builder.Property(prop => prop.Page)
                .IsRequired(true)
                .HasMaxLength(50);
            builder.Property(prop => prop.Content)
                .IsRequired(true);
                
        }
    }
}
