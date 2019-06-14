using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoCore.Models
{
    public class Benefit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Benefitlimit { get; set; }
        public string CategoryName { get; set; }
        public bool? Status { get; set; }
        public Guid Guid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string AddedBy { get; set; }
        public bool? IsDeleted { get; set; }




        public BenefitsCategory BenefitsCategory { get; set; }
    }
}
