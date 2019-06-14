using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NovoCore.Models;


namespace ProviderModule.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Provider> Provider { get; set; }
        public DbSet<ProviderAccount> ProviderAccount { get; set; }
        public DbSet<ProviderAssignee> ProviderAssignee { get; set; }
        public DbSet<ProviderLogin> ProviderLogin { get; set; }
        public DbSet<ProviderRating> ProviderRating { get; set; }
        public DbSet<ProviderServices> ProviderServices { get; set; }
    }
}
