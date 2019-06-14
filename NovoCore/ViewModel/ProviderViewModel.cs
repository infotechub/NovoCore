using NovoCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoCore.ViewModel
{
    public class ProviderViewModel
    {

        public Provider Providers { get; set; }
        public IEnumerable<ProviderAccount> ProviderAccounts { get; set; }
        public IEnumerable<ProviderAssignee> ProviderAssignees { get; set; }
        public IEnumerable<ProviderLogin> ProviderLogins { get; set; }
        public IEnumerable<ProviderRating> ProviderRatings { get; set; }
        public IEnumerable<ProviderServices> ProviderServices { get; set; }
        public IEnumerable<Lga> Lga { get; set; }
        public IEnumerable<State> State { get; set; }
        public IEnumerable<ApplicationUser> ApplicationUsers { get; set; }
      
        public IEnumerable<Enrollee> Enrollee { get; set; }
        public IEnumerable<ClaimBatch> claimBatches { get; set; }
        public IEnumerable<Claim> Claims{ get; set; }
        public IEnumerable<ClaimDrug> ClaimDrugs { get; set; }
        public IEnumerable<ClaimService> ClaimServices { get; set; }
        public IEnumerable<PaymentBatch> PaymentBatches { get; set; }
    }
}
