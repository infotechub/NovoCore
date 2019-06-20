namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("VettingProtocol")]
    public class VettingProtocol
    {
        public int Id { get; set; }

        public string Diagnosis { get; set; }

        public string investigations { get; set; }

        public string treatment { get; set; }

        public string specialist { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }
    }
}
