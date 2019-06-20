namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("PendingDependant")]
    public class PendingDependant
    {
        public int Id { get; set; }

        public byte[] ImgRaw { get; set; }

        public string firstName { get; set; }

        public string lastname { get; set; }

        public DateTime? dob { get; set; }

        public int? sex { get; set; }

        public int? hospital { get; set; }

        public string mobile { get; set; }

        public string preexisting { get; set; }

        public int? relationship { get; set; }

        public string Note { get; set; }

        public string Principalpolicynum { get; set; }

        public string principalGuid { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }

        public bool? Approved { get; set; }
    }
}
