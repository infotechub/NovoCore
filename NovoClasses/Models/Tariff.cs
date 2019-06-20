namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Tariff")]
    public class Tariff
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool? Status { get; set; }

        public int? CreatedBy { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }

        public int? TariffPageId { get; set; }

        public bool? authstatus { get; set; }

        public int? authBy { get; set; }

        public DateTime? AuthorizedDate { get; set; }

        public int? defaultProvider { get; set; }
    }
}
