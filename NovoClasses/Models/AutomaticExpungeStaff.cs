namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("AutomaticExpungeStaff")]
    public class AutomaticExpungeStaff
    {
        public int Id { get; set; }

        public int? StaffId { get; set; }

        public int? CreatedBy { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }

        public int? Subsidiary { get; set; }

        public int? Companyid { get; set; }

        public bool? Showtouser { get; set; }
    }
}
