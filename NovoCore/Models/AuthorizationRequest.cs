using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoCore.Models
{
    public class AuthorizationRequest
    {
        public int Id { get; set; }

        public string ProviderName { get; set; }
        public string Policynumber { get; set; }
        public string Fullname { get; set; }
        public string Company { get; set; }
        public string Diagnosis { get; set; }
        public string Reasonforcode { get; set; }
        public bool? Isnew { get; set; }
        public Guid Guid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsDeleted { get; set; }


        public Enrollee Enrollee { get; set; }
        public Company EnrolleeCompany { get; set; }
        public Provider Provider { get; set; }
    }
}
