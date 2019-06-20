namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("ProviderClaimBK")]
    public class ProviderClaimBK
    {
        public int Id { get; set; }

        public string clientkey { get; set; }

        public string data { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? providerId { get; set; }

        public int? SiteId { get; set; }

        public  Provider Provider { get; set; }
    }
}
