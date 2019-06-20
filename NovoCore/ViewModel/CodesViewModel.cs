using NovoClasses.Models;
using NovoCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoCore.ViewModel
{
    public class CodesViewModel
    {

        public List<AuthorizationCode> AuthorizationCodes { get; set; }
        public List<AuthorizationRequest> AuthorizationRequests { get; set; }
        public List<Staff> Staff { get; set; }
        public List<Company> Company { get; set; }
        public List<ApplicationUser> ApplicationUsers { get; set; }
        public List<Enrollee> Enrollees { get; set; }
    }
}
