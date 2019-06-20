namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public class ConnectcarePaymentDetail
    {
        public int Id { get; set; }

        public string paymentid { get; set; }

        public int? sponsorID { get; set; }

        public string sponsorIDString { get; set; }

        public string beneficiaryID { get; set; }

        public string policyid { get; set; }

        public decimal? amountpaid { get; set; }

        public string planpurchased { get; set; }

        public bool? addon { get; set; }

        public DateTime? paymentDate { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }
    }
}
