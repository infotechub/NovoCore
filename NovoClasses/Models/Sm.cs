namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public class Sm
    {
        public int Id { get; set; }

        public string Msisdn { get; set; }

        public int? EnrolleeId { get; set; }

        public string FromId { get; set; }

        public string Message { get; set; }

        [StringLength(255)]
        public string Status { get; set; }

        [StringLength(255)]
        public string Type { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public DateTime? DateDelivered { get; set; }

        public string ServerResponse { get; set; }

        public string ServerCode { get; set; }

        public string ServerStatus { get; set; }

        public int? CreatedBy { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }
    }
}
