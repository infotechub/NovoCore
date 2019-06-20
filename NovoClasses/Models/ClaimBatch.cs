namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("ClaimBatch")]
    public class ClaimBatch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClaimBatch()
        {
            Claims = new HashSet<Claim>();
            IncomingClaims = new HashSet<IncomingClaim>();
        }

        public int Id { get; set; }

        public int? ProviderId { get; set; }

        public int? month { get; set; }

        public int? year { get; set; }

        [StringLength(255)]
        public string Batch { get; set; }

        [StringLength(255)]
        public string status { get; set; }

        public int? submitedVetbyUser { get; set; }

        public int? submitedReviewbyUser { get; set; }

        public DateTime? SubmitedForReviewDate { get; set; }

        public DateTime? reviewDate { get; set; }

        public int? reviewedBy { get; set; }

        public DateTime? VetDate { get; set; }

        public DateTime? SubmitedForPaymentDate { get; set; }

        public int? submitedPaymentbyUser { get; set; }

        [StringLength(255)]
        public string AuthorizationStatus { get; set; }

        public string AuthorizationNote { get; set; }

        public string DisapprovalNote { get; set; }

        public int? AuthorizedBy { get; set; }

        public int? DisapprovedBy { get; set; }

        public DateTime? AuthorizedDate { get; set; }

        public DateTime? DisapprovalDate { get; set; }

        public string DeletionNote { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }

        public int? paymentbatchId { get; set; }

        public decimal? AmountPaid { get; set; }

        [StringLength(255)]
        public string paymentmethod { get; set; }

        public string paymentref { get; set; }

        public string chequeno { get; set; }

        public string sourceBankName { get; set; }

        public string sourceBankAccountNo { get; set; }

        public string DestBankName { get; set; }

        public string DestBankAccountNo { get; set; }

        public string remark { get; set; }

        public DateTime? paymentdate { get; set; }

        public string paidby { get; set; }

        public int? markpaidby { get; set; }

        public string ProviderName { get; set; }

        public int? claimscountfromclient { get; set; }

        public string paymentmethodstring { get; set; }

        public bool? paymentadvicesent { get; set; }

        public DateTime? datepaymentadvicesent { get; set; }

        public bool? isremote { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<Claim> Claims { get; set; }

        public  PaymentBatch PaymentBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<IncomingClaim> IncomingClaims { get; set; }
    }
}
