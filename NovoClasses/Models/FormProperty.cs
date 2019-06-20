namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("FormProperty")]
    public class FormProperty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormProperty()
        {
            FormListOptions = new HashSet<FormListOption>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string PropertyType { get; set; }

        public string Name { get; set; }

        public string LabelText { get; set; }

        public bool? Required { get; set; }

        public string CssClass { get; set; }

        public string HtmlId { get; set; }

        public int? DisplayOrder { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? WebpageId { get; set; }

        public int? SiteId { get; set; }

        public string PlaceHolder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<FormListOption> FormListOptions { get; set; }
    }
}
