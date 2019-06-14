using System;
using System.Collections.Generic;

namespace NovoCore.Models
{
    public class PaymentBatch
    {
        public PaymentBatch()
        {
            ClaimBatch = new HashSet<ClaimBatch>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public DateTime? Datepaymentstarted { get; set; }
        public DateTime? Datepaymentcompleted { get; set; }
        public DateTime? Terminationdate { get; set; }
        public int? Paidby { get; set; }
        public int? CreatedBy { get; set; }
        public Guid Guid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsDeleted { get; set; }

        public int? Terminatedby { get; set; }

        public virtual ICollection<ClaimBatch> ClaimBatch { get; set; }
    }
}