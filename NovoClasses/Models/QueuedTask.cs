namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("QueuedTask")]
    public class QueuedTask
    {
        public int Id { get; set; }

        public string Data { get; set; }

        public string Type { get; set; }

        [StringLength(255)]
        public string Status { get; set; }

        public int? Tries { get; set; }

        public int? Priority { get; set; }

        public DateTime? QueuedAt { get; set; }

        public DateTime? StartedAt { get; set; }

        public DateTime? CompletedAt { get; set; }

        public DateTime? FailedAt { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }
    }
}
