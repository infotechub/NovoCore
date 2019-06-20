namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("State")]
    public class State
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public long? Zone { get; set; }

        public bool? Status { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }

        public int? EnrolleeDetailsPageId { get; set; }

        public int? EnrolleeListPageId { get; set; }

        public int? EnrolleePageId { get; set; }

        public int? ProviderPageId { get; set; }

        public int? EnrolleeRegPageId { get; set; }

        public int? DelistedProviderPageId { get; set; }
    }
}
