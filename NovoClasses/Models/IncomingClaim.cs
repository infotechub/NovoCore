namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public class IncomingClaim
    {
        public int Id { get; set; }

        public int? providerid { get; set; }

        public int? month { get; set; }

        public int? year { get; set; }

        public DateTime? fullDateofbill { get; set; }

        public string deliveredby { get; set; }

        public DateTime? DateReceived { get; set; }

        public int? receivedBy { get; set; }

        public int? transferedTo { get; set; }

        public int? transferstatus { get; set; }

        public int? noofencounter { get; set; }

        public decimal? totalamount { get; set; }

        [StringLength(255)]
        public string status { get; set; }

        public DateTime? dateTransferAcknowledged { get; set; }

        public string Note { get; set; }

        public string CapturerList { get; set; }

        public DateTime? captureStarted { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? ClaimBatchId { get; set; }

        public int? SiteId { get; set; }

        public string caption { get; set; }

        public bool? IsRemoteSubmission { get; set; }

        public string month_string { get; set; }

        public  ClaimBatch ClaimBatch { get; set; }
    }
}
