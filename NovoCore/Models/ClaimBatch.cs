using System;
using System.Collections.Generic;

namespace NovoCore.Models
{
    public class ClaimBatch
    {

        public ClaimBatch()
        {
            Claim = new HashSet<Claim>();
            IncomingClaims = new HashSet<IncomingClaims>();
        }

        public int Id { get; set; }
        public int? ProviderId { get; set; }
        public string Name { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public string Batch { get; set; }
        public string Status { get; set; }
        public int? SubmitedVetbyUser { get; set; }
        public int? SubmitedReviewbyUser { get; set; }
        public DateTime? SubmitedForReviewDate { get; set; }
        public DateTime? ReviewDate { get; set; }
        public int? ReviewedBy { get; set; }
        public DateTime? VetDate { get; set; }
        public DateTime? SubmitedForPaymentDate { get; set; }
        public int? SubmitedPaymentbyUser { get; set; }
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
        public int? PaymentbatchId { get; set; }
        public decimal? AmountPaid { get; set; }
        public string Paymentmethod { get; set; }
        public string Paymentref { get; set; }
        public string Chequeno { get; set; }
        public string SourceBankName { get; set; }
        public string SourceBankAccountNo { get; set; }
        public string DestBankName { get; set; }
        public string DestBankAccountNo { get; set; }
        public string Remark { get; set; }
        public DateTime? Paymentdate { get; set; }
        public string Paidby { get; set; }
        public int? Markpaidby { get; set; }
        public string ProviderName { get; set; }
        public int? Claimscountfromclient { get; set; }
        public string Paymentmethodstring { get; set; }
        public bool? Paymentadvicesent { get; set; }
        public DateTime? Datepaymentadvicesent { get; set; }
        public bool? Isremote { get; set; }
        public string AddedBy { get; set; }

        public virtual PaymentBatch Paymentbatch { get; set; }
        public virtual ICollection<Claim> Claim { get; set; }
        public virtual ICollection<IncomingClaims> IncomingClaims { get; set; }
    }
}
    
