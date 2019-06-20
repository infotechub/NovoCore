namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("UrlHistory")]
    public class UrlHistory
    {
        public int Id { get; set; }

        public string UrlSegment { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? WebpageId { get; set; }

        public int? SiteId { get; set; }
    }
}
