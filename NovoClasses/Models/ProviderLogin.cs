namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("ProviderLogin")]
    public class ProviderLogin
    {
        public int Id { get; set; }

        public string password { get; set; }

        public bool? passwordchange { get; set; }

        public string browserid { get; set; }

        public string lastloginId { get; set; }

        public DateTime? lastlogin { get; set; }

        public bool? active { get; set; }

        public DateTime? LastClaimSubmited { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? ProviderId { get; set; }

        public int? SiteId { get; set; }

        public string email { get; set; }

        public string Altemail { get; set; }

        public string Altemail2 { get; set; }

        public string Altemail3 { get; set; }
    }
}
