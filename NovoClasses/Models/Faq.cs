namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Faq")]
    public class Faq
    {
        public int Id { get; set; }

        public string Answer { get; set; }

        public string Question { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? ShowFaqsId { get; set; }

        public int? SiteId { get; set; }
    }
}
