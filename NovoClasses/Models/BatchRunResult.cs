namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("BatchRunResult")]
    public class BatchRunResult
    {
        public int Id { get; set; }

        public int? ExecutionOrder { get; set; }

        public decimal? MillisecondsTaken { get; set; }

        [StringLength(255)]
        public string Status { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? BatchRunId { get; set; }

        public int? BatchJobId { get; set; }

        public int? SiteId { get; set; }

        public  BatchJob BatchJob { get; set; }

        public  BatchRun BatchRun { get; set; }
    }
}
