using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoCore.Models
{
    public class Claim
    {

        public Claim()
        {
            ClaimDrug = new HashSet<ClaimDrug>();
            ClaimService = new HashSet<ClaimService>();
        }

        public int Id { get; set; }
        public int? Enrolleeid { get; set; }
        public string EnrolleeFullname { get; set; }
        public string EnrolleeGender { get; set; }
        public string EnrolleeCompanyName { get; set; }
        public int? EnrolleeCompanyId { get; set; }
        public string EnrolleePolicyNumber { get; set; }
        public string EnrolleePlan { get; set; }
        public string ClaimsSerialNo { get; set; }
        public string Evscode { get; set; }
        public string DoctorsName { get; set; }
        public string DoctorsId { get; set; }
        public string AreaOfSpecialty { get; set; }
        public string Signature { get; set; }
        public bool? DoctorSigned { get; set; }
        public DateTime? DoctorSignecDate { get; set; }
        public string SpecialistName { get; set; }
        public string AreaOfSpecialtyforspecialist { get; set; }
        public string Specialistphonenumber { get; set; }
        public bool? SpecialistSigned { get; set; }
        public DateTime? SpecialistSignecDate { get; set; }
        public DateTime? ServiceDate { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public string Durationoftreatment { get; set; }
        public string Diagnosis { get; set; }
        public string TreatmentGiven { get; set; }
        public string TreatmentCode { get; set; }
        public string ReferalCode { get; set; }
        public bool? EnrolleeSigned { get; set; }
        public DateTime? EnrolleeSignDate { get; set; }
        public bool? AllprescibedDrugs { get; set; }
        public bool? LaboratoryInvestigation { get; set; }
        public bool? Admission { get; set; }
        public bool? Feeding { get; set; }
        public string Note { get; set; }
        public string Tag { get; set; }
        public int? CapturedBy { get; set; }
        public int? VettedBy { get; set; }
        public int? RevettedBy { get; set; }
        public DateTime? VettedDate { get; set; }
        public DateTime? ReVettedDate { get; set; }
        public string Status { get; set; }
        public Guid Guid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public string AddedBy { get; set; }
        
        public string Enrolleeage { get; set; }
        public bool? SubmitByProvider { get; set; }
        public string Ipaddressofprovider { get; set; }



        public virtual Enrollee Enrollee { get; set; }
        public int? ClaimBatchId { get; set; }
        public virtual ClaimBatch ClaimBatch { get; set; }

        public int? ProviderId { get; set; }
        public Provider Provider { get; set; }



        public virtual ICollection<ClaimDrug> ClaimDrug { get; set; }
        public virtual ICollection<ClaimService> ClaimService { get; set; }
    }
}
