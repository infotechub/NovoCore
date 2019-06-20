namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("NotificationTable")]
    public class NotificationTable
    {
        public int Id { get; set; }

        public int? Notificationcode { get; set; }

        public string Roles { get; set; }

        public string Description { get; set; }

        public bool? Active { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }
    }
}
