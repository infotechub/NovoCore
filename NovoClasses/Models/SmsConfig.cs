namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("SmsConfig")]
    public class SmsConfig
    {
        public int Id { get; set; }

        public string BdaySmsTemplate { get; set; }

        public bool? PreScheduleText { get; set; }

        public int? Mode { get; set; }

        public bool? Active { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }
    }
}
