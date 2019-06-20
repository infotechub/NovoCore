namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("OfflineMessage")]
    public class OfflineMessage
    {
        public int Id { get; set; }

        public string FromId { get; set; }

        public string ToId { get; set; }

        public string Message { get; set; }

        public string MsgDate { get; set; }

        public bool? Read { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }
    }
}
