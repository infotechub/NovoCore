namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("TempEnrollee")]
    public class TempEnrollee
    {
        public int Id { get; set; }

        public byte[] Imgraw { get; set; }

        public byte[] S_Imgraw { get; set; }

        public byte[] child1_Imgraw { get; set; }

        public byte[] child2_Imgraw { get; set; }

        public byte[] child3_Imgraw { get; set; }

        public byte[] child4_Imgraw { get; set; }

        public string Policynumber { get; set; }

        public string RefPolicynumber { get; set; }

        public bool? HasRefPolicyNumber { get; set; }

        public string Title { get; set; }

        public string Surname { get; set; }

        public string Othernames { get; set; }

        public DateTime? Dob { get; set; }

        public int? Age { get; set; }

        public int? Maritalstatus { get; set; }

        public string Occupation { get; set; }

        public int? Sex { get; set; }

        public string Residentialaddress { get; set; }

        public int? Stateoforiginid { get; set; }

        public string Lga { get; set; }

        public int? Stateofresidence { get; set; }

        public string Mobilenumber { get; set; }

        public string Mobilenumber2 { get; set; }

        public string Emailaddress { get; set; }

        public int? Sponsorshiptype { get; set; }

        public string Sponsorshiptypeothername { get; set; }

        public string Preexistingmedicalhistory { get; set; }

        public string Sponsorshiptypenote { get; set; }

        public int? Companyid { get; set; }

        public int? officestate { get; set; }

        public string BranchName { get; set; }

        public string staffid { get; set; }

        public int? Subscriptionplanid { get; set; }

        public bool? Hasdependents { get; set; }

        public string Specialidcardfield1 { get; set; }

        public string Specialidcardfield2 { get; set; }

        public string Specialidcardfield3 { get; set; }

        public int? Staffprofileid { get; set; }

        public bool? IdCardPrinted { get; set; }

        public string Primaryprovider { get; set; }

        public int? Status { get; set; }

        public bool? Hasactivesubscription { get; set; }

        public bool? Isexpundged { get; set; }

        public string ExpungeNote { get; set; }

        public int? Expungedby { get; set; }

        public DateTime? Dateexpunged { get; set; }

        public int? Createdby { get; set; }

        public DateTime? Datereceived { get; set; }

        public string BranchID { get; set; }

        public string s_Surname { get; set; }

        public string s_Othernames { get; set; }

        public DateTime? s_Dob { get; set; }

        public int? S_Sex { get; set; }

        public string S_mobile { get; set; }

        public string S_email { get; set; }

        public string S_hospital { get; set; }

        public string S_medicalhistory { get; set; }

        public string child1_Surname { get; set; }

        public string child1_Othernames { get; set; }

        public DateTime? child1_Dob { get; set; }

        public int? child1_Sex { get; set; }

        public string child1_mobile { get; set; }

        public string child1_email { get; set; }

        public string child1_hospital { get; set; }

        public string child1_medicalhistory { get; set; }

        public string child2_Surname { get; set; }

        public string child2_Othernames { get; set; }

        public DateTime? child2_Dob { get; set; }

        public int? child2_Sex { get; set; }

        public string child2_mobile { get; set; }

        public string child2_email { get; set; }

        public string child2_hospital { get; set; }

        public string child2_medicalhistory { get; set; }

        public string child3_Surname { get; set; }

        public string child3_Othernames { get; set; }

        public DateTime? child3_Dob { get; set; }

        public int? child3_Sex { get; set; }

        public string child3_mobile { get; set; }

        public string child3_email { get; set; }

        public string child3_hospital { get; set; }

        public string child3_medicalhistory { get; set; }

        public string child4_Surname { get; set; }

        public string child4_Othernames { get; set; }

        public DateTime? child4_Dob { get; set; }

        public int? child4_Sex { get; set; }

        public string child4_mobile { get; set; }

        public string child4_email { get; set; }

        public string child4_hospital { get; set; }

        public string child4_medicalhistory { get; set; }

        public bool? addspouse { get; set; }

        public bool? addchild1 { get; set; }

        public bool? addchild2 { get; set; }

        public bool? addchild3 { get; set; }

        public bool? addchild4 { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? EnrolleePassportId { get; set; }

        public int? SiteId { get; set; }
    }
}
