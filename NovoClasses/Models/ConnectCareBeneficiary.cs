namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("ConnectCareBeneficiary")]
    public class ConnectCareBeneficiary
    {
        public int Id { get; set; }

        public string fullname { get; set; }

        public string gender { get; set; }

        public string country { get; set; }

        public string state { get; set; }

        public string address { get; set; }

        public string email { get; set; }

        public string city { get; set; }

        public string phonenumber { get; set; }

        public string relationship { get; set; }

        public int? age { get; set; }

        public int? sponsorid { get; set; }

        public Guid Guid { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public int? SiteId { get; set; }

        public string BeneficiaryCat { get; set; }

        public byte[] Passport { get; set; }

        public string BeneficiaryID { get; set; }

        public string firstname { get; set; }

        public DateTime? dob { get; set; }

        public string lastname { get; set; }

        public string LGA { get; set; }

        public string GuardianPhonenumber { get; set; }

        public string GuardianEmail { get; set; }

        public string SuggestedProvider { get; set; }

        public string suggestedPlan { get; set; }

        public string PolicyNumber { get; set; }

        public bool? VerificationStatus { get; set; }

        public bool? active { get; set; }

        [StringLength(255)]
        public string Status { get; set; }

        public string Category { get; set; }

        public bool? addon { get; set; }

        public int? Administeredby { get; set; }

        public DateTime? AdministrationDate { get; set; }

        public int? ConnectCareSponsorId { get; set; }

        public string sponsoridstring { get; set; }

        public  ConnectCareSponsor ConnectCareSponsor { get; set; }
    }
}
