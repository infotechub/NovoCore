namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("ProviderAssignee")]
    public class ProviderAssignee
    {
        public int Id { get; set; }

        public int? Providerid { get; set; }

        public int? Userid { get; set; }

        public int? AssignedBy { get; set; }

        public bool? Status { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }
    }
}
