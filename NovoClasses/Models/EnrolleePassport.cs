namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("EnrolleePassport")]
    public class EnrolleePassport
    {
        public int Id { get; set; }

        public byte[] Imgraw { get; set; }

        public int? Enrolleeid { get; set; }

        public string Enrolleepolicyno { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }
    }
}
