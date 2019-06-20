namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("ProviderRating")]
    public class ProviderRating
    {
        public int Id { get; set; }

        public int? providerID { get; set; }

        public int? rating { get; set; }

        public string FeedBack { get; set; }

        public string Fullname { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }

        public int? enrolleeid { get; set; }

        public DateTime? dateaccessed { get; set; }
    }
}
