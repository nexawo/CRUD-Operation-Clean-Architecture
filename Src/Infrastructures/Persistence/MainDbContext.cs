using Nexawo.Application.Common.Interfaces;
using Nexawo.Common;
using Nexawo.Domain.Common;
using Nexawo.Domain.Entities.Main;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Persistence
{
    public class MainDbContext : DbContext, IMainDbContext
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public MainDbContext(DbContextOptions<MainDbContext> options)
            : base(options)
        {
        }
        public MainDbContext(
            DbContextOptions<MainDbContext> options,
            ICurrentUserService currentUserService,
            IDateTime dateTime)
            : base(options)
        {
            _currentUserService = currentUserService;
            _dateTime = dateTime;
        }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceDetail> ServiceDetails { get; set; }
        public DbSet<Referral> Referrals { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            ChangeTracker.DetectChanges();

            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedBy = _currentUserService.GetUserId();
                    entry.Entity.Created = _dateTime.Now;

                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Entity.LastModifiedBy = _currentUserService.GetUserId();
                    entry.Entity.LastModified = _dateTime.Now;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MainDbContext).Assembly);
        }
    }
}

