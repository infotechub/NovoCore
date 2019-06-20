namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("ClaimDrug")]
    public class ClaimDrug
    {
        public int Id { get; set; }

        public string DrugName { get; set; }

        public string DrugDescription { get; set; }

        public string Quantity { get; set; }

        public string rate { get; set; }

        public decimal? InitialAmount { get; set; }

        public decimal? costofdrug { get; set; }

        public bool? flagred { get; set; }

        public int? DrugId { get; set; }

        public decimal? VettedAmount { get; set; }

        public string VettingComment { get; set; }

        [StringLength(255)]
        public string status { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? ClaimId { get; set; }

        public int? SiteId { get; set; }

        public  Claim Claim { get; set; }
    }
}
