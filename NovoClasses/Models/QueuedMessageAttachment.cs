namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("QueuedMessageAttachment")]
    public class QueuedMessageAttachment
    {
        public int Id { get; set; }

        public string FileName { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? QueuedMessageId { get; set; }

        public int? SiteId { get; set; }

        public  QueuedMessage QueuedMessage { get; set; }
    }
}
