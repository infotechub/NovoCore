namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("AdminDisallowedRole")]
    public class AdminDisallowedRole
    {
        public int Id { get; set; }

        public bool? IsRecursive { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? WebpageId { get; set; }

        public int? UserRoleId { get; set; }

        public int? SiteId { get; set; }
    }
}
