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
    
    public  class AuthorizationRequest
    {
        public int Id { get; set; }
        public int providerid { get; set; }
        public string providerName { get; set; }
        public string policynumber { get; set; }
        public string fullname { get; set; }
        public string company { get; set; }
        public string diagnosis { get; set; }
        public string reasonforcode { get; set; }
        public bool isnew { get; set; }
        public System.Guid Guid { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
       
    }
}