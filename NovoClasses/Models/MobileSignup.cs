namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("MobileSignup")]
    public class MobileSignup
    {
        public int Id { get; set; }

        public string PolicyNumber { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string CodeGenerated { get; set; }

        public int? Status { get; set; }

        public string Smsid { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }
    }
}
