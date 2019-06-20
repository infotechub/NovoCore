namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("FormValue")]
    public class FormValue
    {
        public int Id { get; set; }

        public string Value { get; set; }

        public string Key { get; set; }

        public bool? IsFile { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? FormPostingId { get; set; }

        public int? SiteId { get; set; }

        public  FormPosting FormPosting { get; set; }
    }
}
