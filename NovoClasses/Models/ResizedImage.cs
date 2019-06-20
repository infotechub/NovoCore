namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("ResizedImage")]
    public class ResizedImage
    {
        public int Id { get; set; }

        [StringLength(1000)]
        public string Url { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? MediaFileId { get; set; }

        public int? SiteId { get; set; }

        public  MediaFile MediaFile { get; set; }
    }
}
