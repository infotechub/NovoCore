namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public class ProviderService
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string description { get; set; }

        public string OpeningDays { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? providerId { get; set; }

        public int? SiteId { get; set; }

        public  Provider Provider { get; set; }
    }
}
