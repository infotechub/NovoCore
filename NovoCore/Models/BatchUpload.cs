using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoCore.Models
{
    public class BatchUpload
    {
        public int Id { get; set; }
        public string Discriminator { get; set; }
        public string Data { get; set; }
        public int? Tries { get; set; }
        public string Status { get; set; }
        public int TotalRows { get; set; }
        public string AddedBy { get; set; }
        public Guid Guid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsDeleted { get; set; }
      

       
    }
}
