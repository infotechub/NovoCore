namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Staff")]
    public class Staff
    {
       // [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        public string CompanyId { get; set; }

        public int? CompanySubsidiary { get; set; }

        public string StaffFullname { get; set; }

        public int? StaffPlanid { get; set; }

        public bool? HasProfile { get; set; }

        public int? Profileid { get; set; }

        public int? Createdby { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }

        public bool? IsExpunged { get; set; }

        public string StaffId { get; set; }

        public int? NewStaffId { get; set; }

        public DateTime? stafflinkDate { get; set; }

        public int? stafflinkUSer { get; set; }

        public int? StaffJobId { get; set; }
    }
}
