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
    
    public  class ProviderRating
    {
        public int Id { get; set; }
        public int providerID { get; set; }
        public int rating { get; set; }
        public string FeedBack { get; set; }
        public string Fullname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public System.Guid Guid { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
       
        public int enrolleeid { get; set; }
        public DateTime dateaccessed { get; set; }
    }
}
