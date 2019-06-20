namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("DrugTariff")]
    public class DrugTariff
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Strenght { get; set; }

        public string Unit { get; set; }

        public decimal? Price { get; set; }

        public bool? PreauthorizationRequired { get; set; }

        public int? GroupId { get; set; }

        public string Groupname { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }

        public string AlternatePrice { get; set; }

        public string Remark { get; set; }
    }
}
