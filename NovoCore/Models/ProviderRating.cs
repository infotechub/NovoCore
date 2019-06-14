using System;

namespace NovoCore.Models
{
    public class ProviderRating
    {

        public int Id { get; set; }
        public int? ProviderId { get; set; }
        public int? Rating { get; set; }
        public string FeedBack { get; set; }
        public string Fullname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Guid Guid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? Enrolleeid { get; set; }
        public DateTime? Dateaccessed { get; set; }

        public Provider Provider { get; set; }
        public Enrollee Enrollee { get; set; }
    }
}