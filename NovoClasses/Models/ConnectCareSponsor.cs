//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NovoClasses.Models
{
    using System;
    using System.Collections.Generic;
    
    public  class ConnectCareSponsor
    {
        
        public ConnectCareSponsor()
        {
            this.ConnectCareBeneficiaries = new HashSet<ConnectCareBeneficiary>();
        }
    
        public int Id { get; set; }
        public string fullname { get; set; }
        public string gender { get; set; }
        public string occupation { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string phonenumber { get; set; }
        public bool emailsent { get; set; }
        public System.Guid Guid { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
       
        public string SubscriptionType { get; set; }
        public string sponsorID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string secondarysponsor { get; set; }
        public string zipcode { get; set; }
        public bool Addon { get; set; }
        public DateTime SponsorStartDate { get; set; }
        public DateTime PolicyStartDate { get; set; }
        public DateTime PolicyEndDate { get; set; }
        public int PolicynotificationConfig { get; set; }
        public int instalment { get; set; }
        public string policynumner { get; set; }
        public bool active { get; set; }
        public int Administeredby { get; set; }
        public DateTime AdministrationDate { get; set; }
        public int EnrolleeprofileId { get; set; }
        public string sponsorSTRID { get; set; }
        public string policynumber { get; set; }
        public bool pushedtoMatontine { get; set; }
        public DateTime pushedDate { get; set; }
        public int ManageSponsorPageId { get; set; }
    
       
        public ICollection<ConnectCareBeneficiary> ConnectCareBeneficiaries { get; set; }
        
    }
}