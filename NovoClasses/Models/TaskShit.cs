namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("TaskShit")]
    public class TaskShit
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? LastRun { get; set; }

        public long? RunTimerSeconds { get; set; }

        public bool? status { get; set; }

        public bool? Enabled { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }
    }
}
