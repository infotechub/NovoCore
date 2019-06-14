using System;

namespace NovoCore.Models
{
    public class IncomingClaims
    {
        public int Id { get; set; }
        public int? Providerid { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public DateTime? FullDateofbill { get; set; }
        public string Deliveredby { get; set; }
        public DateTime? DateReceived { get; set; }
        public int? ReceivedBy { get; set; }
        public int? TransferedTo { get; set; }
        public int? Transferstatus { get; set; }
        public int? Noofencounter { get; set; }
        public decimal? Totalamount { get; set; }
        public string Status { get; set; }
        public DateTime? DateTransferAcknowledged { get; set; }
        public string Note { get; set; }
        public string CapturerList { get; set; }
        public DateTime? CaptureStarted { get; set; }
        public Guid Guid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? ClaimBatchId { get; set; }
        public string Caption { get; set; }
        public bool? IsRemoteSubmission { get; set; }
        public string MonthString { get; set; }

        public virtual ClaimBatch ClaimBatch { get; set; }
        public Provider Provider { get; set; }
        public ApplicationUser User { get; set; }

    }
}