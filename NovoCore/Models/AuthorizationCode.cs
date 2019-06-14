using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoCore.Models
{
    public class NovoAuthorizationCode
    {

        public int Id { get; set; }
        public string AuthorizationCode { get; set; }
        public string PolicyNumber { get; set; }
        public string EnrolleeName { get; set; }
        public string EnrolleeCompany { get; set; }
        public string Diagnosis { get; set; }
        public string TypeofAuthorization { get; set; }
        public int? EnrolleeAge { get; set; }
        public string Plan { get; set; }
        public string Note { get; set; }
        public string Requestername { get; set; }
        public string Requesterphone { get; set; }
        public int? Generatedby { get; set; }
        public int? Authorizedby { get; set; }
        public bool? AcknowledgedByAuthorizer { get; set; }
        public Guid Guid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? Isadmission { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public int? DaysApprovded { get; set; }
        public DateTime? DischargeDate { get; set; }
        public string AdmissionStatus { get; set; }
        public bool? IsNhis { get; set; }
        public bool? Isdelivery { get; set; }
        public bool? Deliverysmssent { get; set; }
        public string TreatmentAuthorized { get; set; }

    
        public Enrollee Enrollee { get; set; }
        public Provider Provider { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
