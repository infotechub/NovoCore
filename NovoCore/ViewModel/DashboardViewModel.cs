using NovoClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoCore.ViewModel
{
    public class Dashboard
    {
        public Provider Provider { get; set; }
        public Enrollee Enrollee { get; set; }
        public Staff Staff { get; set; }
        public Company Company { get; set; }
        public Notification Notification { get; set; }
        public Claim Claim { get; set; }
        public ClaimBatch ClaimBatch { get; set; }
        public ClaimDrug ClaimDrug { get; set; }
        public ClaimService ClaimService { get; set; }
        public PaymentBatch PaymentBatch { get; set; }
        public FacilitiesAllowed FacilitiesAllowed { get; set; }
    }
}
