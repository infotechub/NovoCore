namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("AuthorizationRequest")]
    public class AuthorizationRequest
    {
        public int Id { get; set; }

        public int? providerid { get; set; }

        public string providerName { get; set; }

        public string policynumber { get; set; }

        public string fullname { get; set; }

        public string company { get; set; }

        public string diagnosis { get; set; }

        public string reasonforcode { get; set; }

        public bool? isnew { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }
    }
}
