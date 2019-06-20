namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("ClaimService")]
    public class ClaimService
    {
        public int Id { get; set; }

        public string ServiceName { get; set; }

        public string ServiceDescription { get; set; }

        public string Duration { get; set; }

        public string rate { get; set; }

        public decimal? InitialAmount { get; set; }

        public decimal? costofdrug { get; set; }

        public bool? flagred { get; set; }

        public int? ServiceId { get; set; }

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
