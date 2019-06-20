namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Query")]
    public class Query
    {
     //  [Key]
      // [Column(Order = 0)]
     //  [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column(TypeName = "image")]
        public byte[] Imgraw { get; set; }

        [Column(TypeName = "image")]
        public byte[] S_Imgraw { get; set; }

        [Column(TypeName = "image")]
        public byte[] child1_Imgraw { get; set; }

        [Column(TypeName = "image")]
        public byte[] child2_Imgraw { get; set; }

        [Column(TypeName = "image")]
        public byte[] child3_Imgraw { get; set; }

        [Column(TypeName = "image")]
        public byte[] child4_Imgraw { get; set; }

        [Column(TypeName = "ntext")]
        public string Policynumber { get; set; }

        [Column(TypeName = "ntext")]
        public string RefPolicynumber { get; set; }

        public bool? HasRefPolicyNumber { get; set; }

        [Column(TypeName = "ntext")]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Surname { get; set; }

        [Column(TypeName = "ntext")]
        public string Othernames { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Dob { get; set; }

        public int? Age { get; set; }

        public int? Maritalstatus { get; set; }

        [Column(TypeName = "ntext")]
        public string Occupation { get; set; }

        public int? Sex { get; set; }

        [Column(TypeName = "ntext")]
        public string Residentialaddress { get; set; }

        public int? Stateoforiginid { get; set; }

        [Column(TypeName = "ntext")]
        public string Lga { get; set; }

        public int? Stateofresidence { get; set; }

        [Column(TypeName = "ntext")]
        public string Mobilenumber { get; set; }

        [Column(TypeName = "ntext")]
        public string Mobilenumber2 { get; set; }

        [Column(TypeName = "ntext")]
        public string Emailaddress { get; set; }

        public int? Sponsorshiptype { get; set; }

        [Column(TypeName = "ntext")]
        public string Sponsorshiptypeothername { get; set; }

        [Column(TypeName = "ntext")]
        public string Preexistingmedicalhistory { get; set; }

        [Column(TypeName = "ntext")]
        public string Sponsorshiptypenote { get; set; }

        public int? Companyid { get; set; }

        public int? officestate { get; set; }

        [Column(TypeName = "ntext")]
        public string BranchName { get; set; }

        [Column(TypeName = "ntext")]
        public string staffid { get; set; }

        public int? Subscriptionplanid { get; set; }

        public bool? Hasdependents { get; set; }

        [Column(TypeName = "ntext")]
        public string Specialidcardfield1 { get; set; }

        [Column(TypeName = "ntext")]
        public string Specialidcardfield2 { get; set; }

        [Column(TypeName = "ntext")]
        public string Specialidcardfield3 { get; set; }

        public int? Staffprofileid { get; set; }

        public bool? IdCardPrinted { get; set; }

        [Column(TypeName = "ntext")]
        public string Primaryprovider { get; set; }

        public int? Status { get; set; }

        public bool? Hasactivesubscription { get; set; }

        public bool? Isexpundged { get; set; }

        [Column(TypeName = "ntext")]
        public string ExpungeNote { get; set; }

        public int? Expungedby { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Dateexpunged { get; set; }

        public int? Createdby { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Datereceived { get; set; }

        [Column(TypeName = "ntext")]
        public string BranchID { get; set; }

        [Column(TypeName = "ntext")]
        public string s_Surname { get; set; }

        [Column(TypeName = "ntext")]
        public string s_Othernames { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? s_Dob { get; set; }

        public int? S_Sex { get; set; }

        [Column(TypeName = "ntext")]
        public string S_mobile { get; set; }

        [Column(TypeName = "ntext")]
        public string S_email { get; set; }

        [Column(TypeName = "ntext")]
        public string S_hospital { get; set; }

        [Column(TypeName = "ntext")]
        public string S_medicalhistory { get; set; }

        [Column(TypeName = "ntext")]
        public string child1_Surname { get; set; }

        [Column(TypeName = "ntext")]
        public string child1_Othernames { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? child1_Dob { get; set; }

        public int? child1_Sex { get; set; }

        [Column(TypeName = "ntext")]
        public string child1_mobile { get; set; }

        [Column(TypeName = "ntext")]
        public string child1_email { get; set; }

        [Column(TypeName = "ntext")]
        public string child1_hospital { get; set; }

        [Column(TypeName = "ntext")]
        public string child1_medicalhistory { get; set; }

        [Column(TypeName = "ntext")]
        public string child2_Surname { get; set; }

        [Column(TypeName = "ntext")]
        public string child2_Othernames { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? child2_Dob { get; set; }

        public int? child2_Sex { get; set; }

        [Column(TypeName = "ntext")]
        public string child2_mobile { get; set; }

        [Column(TypeName = "ntext")]
        public string child2_email { get; set; }

        [Column(TypeName = "ntext")]
        public string child2_hospital { get; set; }

        [Column(TypeName = "ntext")]
        public string child2_medicalhistory { get; set; }

        [Column(TypeName = "ntext")]
        public string child3_Surname { get; set; }

        [Column(TypeName = "ntext")]
        public string child3_Othernames { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? child3_Dob { get; set; }

        public int? child3_Sex { get; set; }

        [Column(TypeName = "ntext")]
        public string child3_mobile { get; set; }

        [Column(TypeName = "ntext")]
        public string child3_email { get; set; }

        [Column(TypeName = "ntext")]
        public string child3_hospital { get; set; }

        [Column(TypeName = "ntext")]
        public string child3_medicalhistory { get; set; }

        [Column(TypeName = "ntext")]
        public string child4_Surname { get; set; }

        [Column(TypeName = "ntext")]
        public string child4_Othernames { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? child4_Dob { get; set; }

        public int? child4_Sex { get; set; }

        [Column(TypeName = "ntext")]
        public string child4_mobile { get; set; }

        [Column(TypeName = "ntext")]
        public string child4_email { get; set; }

        [Column(TypeName = "ntext")]
        public string child4_hospital { get; set; }

        [Column(TypeName = "ntext")]
        public string child4_medicalhistory { get; set; }

        public bool? addspouse { get; set; }

        public bool? addchild1 { get; set; }

        public bool? addchild2 { get; set; }

        public bool? addchild3 { get; set; }

        public bool? addchild4 { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid Guid { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreatedOn { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? EnrolleePassportId { get; set; }

        public int? SiteId { get; set; }
    }
}
