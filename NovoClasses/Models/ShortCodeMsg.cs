namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("ShortCodeMsg")]
    public class ShortCodeMsg
    {
        public int Id { get; set; }

        public string Mobile { get; set; }

        public string Msg { get; set; }

        public DateTime? MsgTime { get; set; }

        public bool? Status { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }
    }
}
