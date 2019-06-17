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
    
    public  class BatchRunResult
    {
        public int Id { get; set; }
        public int ExecutionOrder { get; set; }
        public decimal MillisecondsTaken { get; set; }
        public string Status { get; set; }
        public System.Guid Guid { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public int BatchRunId { get; set; }
        public int BatchJobId { get; set; }
       
    
        public  BatchJob BatchJob { get; set; }
        public  BatchRun BatchRun { get; set; }
    }
}
