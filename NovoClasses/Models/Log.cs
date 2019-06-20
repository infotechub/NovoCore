namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Log")]
    public class Log
    {
        public int Id { get; set; }

        public byte[] Error { get; set; }

        public string Message { get; set; }

        public string Detail { get; set; }

        [StringLength(255)]
        public string Type { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }
    }
}
