using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexawo.Domain.Entities.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Persistence.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(e => e.EmployeeId)
                .IsRequired();
            builder.Property(e => e.FirstName)
                .IsRequired().HasMaxLength(30);
            builder.Property(e => e.LastName)
                .IsRequired().HasMaxLength(30);
            builder.Property(e => e.CNIC)
                .IsRequired().HasMaxLength(16);
            builder.Property(e => e.Email)
                .IsRequired().HasMaxLength(30);
        }
    }
}
