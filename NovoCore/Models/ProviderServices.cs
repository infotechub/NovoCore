using System;

namespace NovoCore.Models
{
    public class ProviderServices
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OpeningDays { get; set; }
        public Guid Guid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? ProviderId { get; set; }
        public string AddedBy { get; set; }


        public  Provider Provider { get; set; }
    }
}