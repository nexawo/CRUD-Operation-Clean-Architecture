using Microsoft.EntityFrameworkCore;
using Nexawo.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.UnitTests.Common
{
    public class MainContextFactory
    {
        public static MainDbContext Create()
        {
            var options = new DbContextOptionsBuilder<MainDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var context = new MainDbContext(options);

            context.Database.EnsureCreated();

            context.Tenants.AddRange(new[] {
                new Nexawo.Domain.Entities.Main.Tenant { TenantId = "1", Name = "B1 Tenant",DBConnection = "Connection String" },
                new Nexawo.Domain.Entities.Main.Tenant { TenantId = "2", Name = "B2 Tenant",DBConnection = "Connection String" },
                new Nexawo.Domain.Entities.Main.Tenant { TenantId = "3", Name = "B3 Tenant",DBConnection = "Connection String" },
            });

            context.SaveChanges();

            return context;
        }

        public static void Destroy(MainDbContext context)
        {
            context.Database.EnsureDeleted();

            context.Dispose();
        }

    }
}
