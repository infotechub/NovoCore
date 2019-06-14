using System;

namespace NovoCore.Models
{
    public class ProviderLogin
    {

        public int Id { get; set; }
        public string Password { get; set; }
        public bool? Passwordchange { get; set; }
        public string Browserid { get; set; }
        public string LastloginId { get; set; }
        public DateTime? Lastlogin { get; set; }
        public bool? Active { get; set; }
        public DateTime? LastClaimSubmited { get; set; }
        public Guid Guid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? ProviderId { get; set; }
        public string Email { get; set; }
        public string Altemail { get; set; }
        public string Altemail2 { get; set; }
        public string Altemail3 { get; set; }
        public string AddedBy { get; set; }


        public Provider Provider { get; set; }
     
    }
}