namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("CompanySubsidiary")]
    public class CompanySubsidiary
    {
        public int Id { get; set; }

        public int? ParentcompanyId { get; set; }

        public string Subsidaryname { get; set; }

        public string Subsidaryprofile { get; set; }

        public int? CreatedBy { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }
    }
}
