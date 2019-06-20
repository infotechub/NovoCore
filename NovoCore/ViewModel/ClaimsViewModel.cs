using NovoClasses.Models;
using NovoCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoCore.ViewModel
{
    public class Bills
    {

        public List<Provider> Provider { get; set; }
        public List<Enrollee> Enrollee { get; set; }
        public List<Staff> Staff { get; set; }
        public List<Company> Company { get; set; }
        public List<IncomingClaim> IncomingClaims { get; set; }
        public List<Claim> Claim { get; set; }
        public List<ClaimBatch> ClaimBatch { get; set; }
        public List<ClaimDrug> ClaimDrug { get; set; }
        public List<ClaimService> ClaimService { get; set; }
        public List<PaymentBatch> PaymentBatch { get; set; }
        public List<ApplicationUser> ApplicationUsers { get; set; }
    }
}
