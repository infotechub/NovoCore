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
    
    public  class Staff
    {
        public int Id { get; set; }
        public string CompanyId { get; set; }
        public int CompanySubsidiary { get; set; }
        public string StaffFullname { get; set; }
        public int StaffPlanid { get; set; }
        public bool HasProfile { get; set; }
        public int Profileid { get; set; }
        public int Createdby { get; set; }
        public System.Guid Guid { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
       
        public bool IsExpunged { get; set; }
        public string StaffId { get; set; }
        public int NewStaffId { get; set; }
        public DateTime stafflinkDate { get; set; }
        public int stafflinkUSer { get; set; }
        public int StaffJobId { get; set; }
    }
}
