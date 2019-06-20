namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("ProviderAccount")]
    public class ProviderAccount
    {
        public int Id { get; set; }

        public int? Providerid { get; set; }

        public int? BankId { get; set; }

        public string Bankaccountname { get; set; }

        public string Bankaccountnum { get; set; }

        public string Bankbranch { get; set; }

        public string Note { get; set; }

        public bool? Status { get; set; }

        public int? AuthorizationStatus { get; set; }

        public string AuthorizationNote { get; set; }

        public string DisapprovalNote { get; set; }

        public int? AuthorizedBy { get; set; }

        public int? DisapprovedBy { get; set; }

        public DateTime? AuthorizedDate { get; set; }

        public DateTime? DisapprovalDate { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }
    }
}
