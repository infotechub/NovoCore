using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoCore.Models
{
    public class FacilitiesAllowed
    {
        public int Id { get; set; }
        public string CompanyPlanId { get; set; }
        public string Planid { get; set; }
        public string ProviderId { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public Guid? Guid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? SiteId { get; set; }
        public int? FacilitiesAllowedPageId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyId { get; set; }
        public string AddedBy { get; set; }
        public string DeletedBy { get; set; }
    }
}
