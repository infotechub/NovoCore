namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("ScheduledTask")]
    public class ScheduledTask
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public int? EveryXSeconds { get; set; }

        public DateTime? LastQueuedAt { get; set; }

        public DateTime? LastComplete { get; set; }

        [StringLength(255)]
        public string Status { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }
    }
}
