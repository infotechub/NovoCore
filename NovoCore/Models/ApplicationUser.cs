using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoCore.Models
{
    public class ApplicationUser : IdentityUser
    {

        public ApplicationUser() : base() { }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  bool? IsActive { get; set; }
        public string LastLoginDate { get; set; }
        public int? LoginAttempts { get; set; }
        public string CugMobileNumber { get; set; }
        public string Dob { get; set; }
        public Guid Guid { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
