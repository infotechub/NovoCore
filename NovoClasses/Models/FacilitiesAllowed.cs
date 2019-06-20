namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("FacilitiesAllowed")]
    public class FacilitiesAllowed
    {
        public int Id { get; set; }

        public string CompanyPlanId { get; set; }

        public string Planid { get; set; }

        public string ProviderId { get; set; }

        public string Address { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public Guid? Guid { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreatedOn { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DeletedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }

        public int? FacilitiesAllowedPageId { get; set; }

        public string CompanyName { get; set; }

        public string CompanyId { get; set; }

        public string AddedBy { get; set; }

        public string DeletedBy { get; set; }
    }
}
