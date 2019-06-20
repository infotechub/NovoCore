namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("TerminatedSubscription")]
    public class TerminatedSubscription
    {
        public int Id { get; set; }

        public int? SubscriptionId { get; set; }

        public DateTime? Terminationdate { get; set; }

        public int? TerminatedByUserId { get; set; }

        public string Note { get; set; }

        public int? AuthorizationStatus { get; set; }

        public string AuthorizationNote { get; set; }

        public string AuthorizedBy { get; set; }

        public DateTime? AuthorizedDate { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }
    }
}
