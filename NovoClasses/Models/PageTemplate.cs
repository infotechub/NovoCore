namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("PageTemplate")]
    public class PageTemplate
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PageTemplateName { get; set; }

        public string PageType { get; set; }

        public string UrlGeneratorType { get; set; }

        public bool? SingleUse { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? LayoutId { get; set; }

        public int? SiteId { get; set; }
    }
}
