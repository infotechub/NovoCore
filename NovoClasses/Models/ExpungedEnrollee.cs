namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("ExpungedEnrollee")]
    public class ExpungedEnrollee
    {
        public int Id { get; set; }

        public int? Enrolleeid { get; set; }

        public string Enrolleepolicyno { get; set; }

        public string ExpungeNote { get; set; }

        public int? Expungedby { get; set; }

        public DateTime? Dateexpunged { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }
    }
}
