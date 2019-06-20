namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("StaffUploadJob")]
    public class StaffUploadJob
    {
        public int Id { get; set; }

        public string filelink { get; set; }

        [StringLength(255)]
        public string JobStatus { get; set; }

        public int? UploadedBy { get; set; }

        public int? CompanyID { get; set; }

        public int? Subsidiary { get; set; }

        [StringLength(255)]
        public string ExpungeMode { get; set; }

        public int? TotalRecord { get; set; }

        public int? TotalRecordDone { get; set; }

        public int? TotalRecordSuccess { get; set; }

        public int? TotalRecordFailed { get; set; }

        public int? TotalStaffForExpunged { get; set; }

        public int? TotalStaffAdded { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? FinishTime { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }

        public string errorlist { get; set; }

        public string Analysislink { get; set; }

        public bool? approved { get; set; }

        public DateTime? dateapproved { get; set; }

        public int? approvedby { get; set; }
    }
}
