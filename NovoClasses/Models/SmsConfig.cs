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
    
    public  class SmsConfig
    {
        public int Id { get; set; }
        public string BdaySmsTemplate { get; set; }
        public bool PreScheduleText { get; set; }
        public int Mode { get; set; }
        public bool Active { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public System.Guid Guid { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
       
    }
}
