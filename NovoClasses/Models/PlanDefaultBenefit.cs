namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("PlanDefaultBenefit")]
    public class PlanDefaultBenefit
    {
        public int Id { get; set; }

        public int? Planid { get; set; }

        public int? BenefitId { get; set; }

        public string BenefitLimit { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }
    }
}
