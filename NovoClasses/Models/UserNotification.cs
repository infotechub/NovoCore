namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("UserNotification")]
    public class UserNotification
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string Message { get; set; }

        public int? Type { get; set; }

        public int? Target { get; set; }

        public bool? Read { get; set; }

        public string ClickAction { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? RoleId { get; set; }

        public int? SiteId { get; set; }
    }
}
