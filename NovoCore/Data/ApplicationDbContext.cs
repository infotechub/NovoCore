using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NovoClasses.Models;
using NovoCore.Models;

namespace NovoCore.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }


        public DbSet<NovoAuthorizationCode> AuthorizationCode { get; set; }
        public DbSet<AuthorizationRequest> AuthorizationRequest { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<Benefit> Benefit { get; set; }
        public DbSet<BenefitsCategory> BenefitsCategory { get; set; }
        public DbSet<Claim> Claim { get; set; }
        public DbSet<ClaimBatch> ClaimBatch { get; set; }
        public DbSet<ClaimDrug> ClaimDrug { get; set; }
        public DbSet<ClaimService> ClaimService { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyBranch> CompanyBranch { get; set; }
        public DbSet<EnrolleePassport> EnrolleePassport { get; set; }
        public DbSet<Enrollee> Enrollee { get; set; }
        public DbSet<IncomingClaim> IncomingClaims { get; set; }
        public DbSet<Lga> Lga { get; set; }
        public DbSet<PaymentBatch> PaymentBatch { get; set; }
        public DbSet<Provider> Provider { get; set; }
        public DbSet<ProviderAccount> ProviderAccount { get; set; }
        public DbSet<ProviderAssignee> ProviderAssignee { get; set; }
        public DbSet<ProviderLogin> ProviderLogin { get; set; }
        public DbSet<ProviderRating> ProviderRating { get; set; }
        public DbSet<ProviderService> ProviderServices { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<CompanySubsidiary> CompanySubsidiary { get; set; }
        public DbSet<FacilitiesAllowed> FacilitiesAllowed { get; set; }
        public DbSet<Staff> Staff { get; set; }
    }

        
}
