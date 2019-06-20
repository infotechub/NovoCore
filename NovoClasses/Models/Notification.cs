namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Notification")]
    public class Notification
    {
        public int Id { get; set; }

        public string Message { get; set; }

        [StringLength(255)]
        public string NotificationType { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int UserId { get; set; }

        public int ProviderId { get; set; }

        public int? SiteId { get; set; }

        public string status { get; set; }
    }
}
