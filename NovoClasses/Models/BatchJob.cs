namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("BatchJob")]
    public class BatchJob
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BatchJob()
        {
            BatchRunResults = new HashSet<BatchRunResult>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string discriminator { get; set; }

        public string Data { get; set; }

        public int? Tries { get; set; }

        [StringLength(255)]
        public string Status { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? BatchId { get; set; }

        public int? SiteId { get; set; }

        public string IndexName { get; set; }

        public string UrlSegment { get; set; }

        public  Batch Batch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<BatchRunResult> BatchRunResults { get; set; }
    }
}
