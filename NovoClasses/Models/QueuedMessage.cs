namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("QueuedMessage")]
    public class QueuedMessage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QueuedMessage()
        {
            QueuedMessageAttachments = new HashSet<QueuedMessageAttachment>();
        }

        public int Id { get; set; }

        public string Body { get; set; }

        public string FromAddress { get; set; }

        public string FromName { get; set; }

        public string ToAddress { get; set; }

        public string ToName { get; set; }

        public string Cc { get; set; }

        public string Bcc { get; set; }

        public string Subject { get; set; }

        public DateTime? SentOn { get; set; }

        public int? Tries { get; set; }

        public bool? IsHtml { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<QueuedMessageAttachment> QueuedMessageAttachments { get; set; }
    }
}
