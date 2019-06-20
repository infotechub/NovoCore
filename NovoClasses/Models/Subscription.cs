namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Subscription")]
    public class Subscription
    {
        public int Id { get; set; }

        public string SubscriptionCode { get; set; }

        public int? CompanyId { get; set; }

        public string Companyplans { get; set; }

        public DateTime? Startdate { get; set; }

        public int? Duration { get; set; }

        public DateTime? Expirationdate { get; set; }

        public string Note { get; set; }

        public int? Status { get; set; }

        public int? Createdby { get; set; }

        public int? AuthorizationStatus { get; set; }

        public string AuthorizationNote { get; set; }

        public string DisapprovalNote { get; set; }

        public string TerminationNote { get; set; }

        public int? Terminatedby { get; set; }

        public int? AuthorizedBy { get; set; }

        public int? DisapprovedBy { get; set; }

        public DateTime? AuthorizedDate { get; set; }

        public DateTime? DisapprovalDate { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }

        [StringLength(255)]
        public string SubscriptionMode { get; set; }

        public string Subsidiaries { get; set; }

        public int? SubsidiaryId { get; set; }
    }
}
