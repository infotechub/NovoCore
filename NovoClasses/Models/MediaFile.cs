namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("MediaFile")]
    public class MediaFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MediaFile()
        {
            ResizedImages = new HashSet<ResizedImage>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string MediaFileType { get; set; }

        public string Description { get; set; }

        [StringLength(4000)]
        public string Title { get; set; }

        public string FileUrl { get; set; }

        public string FileExtension { get; set; }

        public string ContentType { get; set; }

        public long? ContentLength { get; set; }

        public string FileName { get; set; }

        public int? DisplayOrder { get; set; }

        public int? Width { get; set; }

        public int? Height { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? MediaCategoryId { get; set; }

        public int? SiteId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<ResizedImage> ResizedImages { get; set; }
    }
}
