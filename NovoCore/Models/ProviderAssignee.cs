using System;

namespace NovoCore.Models
{
    public class ProviderAssignee
    {
        public int Id { get; set; }
       
        public int? AssignedBy { get; set; }
        public bool? Status { get; set; }
        public Guid Guid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public string AddedBy { get; set; }

        public int Providerid { get; set; }
        public Provider Provider { get; set; }
     
        public ApplicationUser User { get; set; }
    }
}