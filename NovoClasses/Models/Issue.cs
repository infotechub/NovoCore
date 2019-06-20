namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public class Issue
    {
        public int Id { get; set; }

        public string subject { get; set; }

        public string Details { get; set; }

        [StringLength(255)]
        public string status { get; set; }

        public string providers { get; set; }

        public string companies { get; set; }

        [StringLength(255)]
        public string prority { get; set; }

        public string users { get; set; }

        public string report { get; set; }

        public bool? escalated { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }
    }
}
