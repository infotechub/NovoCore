namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Service")]
    public class NovoService
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public bool? Status { get; set; }

        public string Description { get; set; }

        public int? CreatedBy { get; set; }

        public int? AuthorizationStatus { get; set; }

        public string AuthorizationNote { get; set; }

        public string DisapprovalNote { get; set; }

        public int? AuthorizedBy { get; set; }

        public int? DisapprovedBy { get; set; }

        public DateTime? AuthorizedDate { get; set; }

        public DateTime? DisapprovalDate { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }

        public int? ServicesPageId { get; set; }
    }
}
