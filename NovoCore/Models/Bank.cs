using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoCore.Models
{
    public class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Guid Guid { get; set; }
        public string AddedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
