using System;

namespace NovoCore.Models
{
    public class ClaimDrug
    {

        public int Id { get; set; }
        public string DrugName { get; set; }
        public string DrugDescription { get; set; }
        public string Quantity { get; set; }
        public string Rate { get; set; }
        public decimal? InitialAmount { get; set; }
        public decimal? Costofdrug { get; set; }
        public bool? Flagred { get; set; }
        public int? DrugId { get; set; }
        public decimal? VettedAmount { get; set; }
        public string VettingComment { get; set; }
        public string Status { get; set; }
        public Guid Guid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsDeleted { get; set; }


        public int? ClaimId { get; set; }
        public virtual Claim Claim { get; set; }
    }
}