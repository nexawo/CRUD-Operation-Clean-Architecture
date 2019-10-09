using Nexawo.Domain.Entities.Main;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nexawo.Application.Common.Interfaces
{
    public interface IMainDbContext
    {
        DbSet<Tenant> Tenants { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Service> Services { get; set;}
        DbSet<Nexawo.Domain.Entities.Main.Employee> Employees { get; set; }
        DbSet<ServiceDetail> ServiceDetails { get; set; }
        DbSet<Nexawo.Domain.Entities.Main.Referral> Referrals { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
