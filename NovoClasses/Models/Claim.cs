namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Claim")]
    public class Claim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Claim()
        {
            ClaimDrugs = new HashSet<ClaimDrug>();
            ClaimServices = new HashSet<ClaimService>();
        }

        public int Id { get; set; }

        public int? ProviderId { get; set; }

        public int? Enrolleeid { get; set; }

        public string enrolleeFullname { get; set; }

        public string enrolleeGender { get; set; }

        public string enrolleeCompanyName { get; set; }

        public int? enrolleeCompanyId { get; set; }

        public string enrolleePolicyNumber { get; set; }

        public string EnrolleePlan { get; set; }

        public string ClaimsSerialNo { get; set; }

        public string EVSCode { get; set; }

        public string DoctorsName { get; set; }

        public string DoctorsId { get; set; }

        public string AreaOfSpecialty { get; set; }

        public string Signature { get; set; }

        public bool? DoctorSigned { get; set; }

        public DateTime? DoctorSignecDate { get; set; }

        public string specialistName { get; set; }

        public string AreaOfSpecialtyforspecialist { get; set; }

        public string specialistphonenumber { get; set; }

        public bool? specialistSigned { get; set; }

        public DateTime? specialistSignecDate { get; set; }

        public DateTime? ServiceDate { get; set; }

        public DateTime? AdmissionDate { get; set; }

        public DateTime? DischargeDate { get; set; }

        public string Durationoftreatment { get; set; }

        public string Diagnosis { get; set; }

        public string TreatmentGiven { get; set; }

        public string TreatmentCode { get; set; }

        public string referalCode { get; set; }

        public bool? enrolleeSigned { get; set; }

        public DateTime? EnrolleeSignDate { get; set; }

        public bool? AllprescibedDrugs { get; set; }

        public bool? LaboratoryInvestigation { get; set; }

        public bool? Admission { get; set; }

        public bool? Feeding { get; set; }

        public string Note { get; set; }

        [StringLength(255)]
        public string Tag { get; set; }

        public int? capturedBy { get; set; }

        public string capturedName { get; set; }

        public int? vettedBy { get; set; }

        public int? RevettedBy { get; set; }

        public DateTime? VettedDate { get; set; }

        public DateTime? ReVettedDate { get; set; }

        [StringLength(255)]
        public string status { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? ClaimBatchId { get; set; }

        public int? SiteId { get; set; }

        public string enrolleeage { get; set; }

        public string ClientsideID { get; set; }

        public string diagnosticsIDString { get; set; }

        public bool? SubmitByProvider { get; set; }

        public string ipaddressofprovider { get; set; }

        public  ClaimBatch ClaimBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<ClaimDrug> ClaimDrugs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<ClaimService> ClaimServices { get; set; }
    }
}
