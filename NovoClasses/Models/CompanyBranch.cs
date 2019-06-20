namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("CompanyBranch")]
    public class CompanyBranch
    {
        public int Id { get; set; }

        public int? Statecode { get; set; }

        public string Branch { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? companyId { get; set; }

        public int? SiteId { get; set; }

        public  Company Company { get; set; }
    }
}
