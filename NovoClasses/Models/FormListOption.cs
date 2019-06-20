namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("FormListOption")]
    public class FormListOption
    {
        public int Id { get; set; }

        public string Value { get; set; }

        public bool? Selected { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? FormPropertyId { get; set; }

        public int? SiteId { get; set; }

        public  FormProperty FormProperty { get; set; }
    }
}
