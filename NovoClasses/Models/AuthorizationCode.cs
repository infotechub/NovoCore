namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("AuthorizationCode")]
    public class AuthorizationCode
    {
        public int Id { get; set; }

        [Column("authorizationCode")]
        public string authorizationCode1 { get; set; }

        public string policyNumber { get; set; }

        public string enrolleeName { get; set; }

        public string EnrolleeCompany { get; set; }

        public string Diagnosis { get; set; }

        public string TypeofAuthorization { get; set; }

        public int? enrolleeAge { get; set; }

        public int? enrolleeID { get; set; }

        public string Plan { get; set; }

        public string Note { get; set; }

        public string requestername { get; set; }

        public string requesterphone { get; set; }

        public int? provider { get; set; }

        public int? generatedby { get; set; }

        public int? Authorizedby { get; set; }

        public bool? AcknowledgedByAuthorizer { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }

        public bool? Isadmission { get; set; }

        public DateTime? AdmissionDate { get; set; }

        public int? DaysApprovded { get; set; }

        public DateTime? DischargeDate { get; set; }

        [StringLength(255)]
        public string admissionStatus { get; set; }

        public bool? IsNHIS { get; set; }

        public bool? isdelivery { get; set; }

        public bool? deliverysmssent { get; set; }

        public string treatmentAuthorized { get; set; }

        public string status { get; set; }
    }
}
