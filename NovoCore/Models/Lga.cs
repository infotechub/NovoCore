using System;

namespace NovoCore.Models
{
    public class Lga
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public long? State { get; set; }
        public bool? Status { get; set; }
        public Guid Guid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}