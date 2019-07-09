using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NovoClasses.Models;
using NovoCore.Data;
using NovoCore.ViewModel;

namespace ProviderModule.Controllers
{
    //[Route("api/[Controller]")]
    [EnableCors("AllowOrigin")]
    public class DashboardController : Controller
    {
        private ApplicationDbContext _context;
        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        // [HttpGet]
        //[Route("api/[Controller]")]
        public ViewResult Index(int Id, int ProviderId, string StaffId, string Policynumber, string Mobilenumber, string StaffFullname)
        {
            // var previousDate = DateTime.Now.AddMonths(-1);
            //  var date = new DateTime(previousDate.Year, previousDate.Month, DateTime.Now.Day);
            //   var providers = _context.Providers.Where(x => x.Id == 1029);
            //  ViewBag.subittedcount = _context.Claims.Count(x => x.ProviderId == 1029 && x.status == "Vetting");
            //   ViewBag.savedcount = _context.Claims.Count(x => x.ProviderId == 1029 && x.status == "Captured");
            //   ViewBag.facilitiesallowed = _context.FacilitiesAlloweds;
            //  ViewBag.enrollee = _context.Enrollees.Where(x => x.Policynumber == "NHA-428025498745");
            // ViewBag.ClaimBatch = _context.Claims.Where(x => x.ProviderId == 1029).Include(c => c.ClaimDrugs).Include(s => s.ClaimServices);

            //ViewBag.facilitiesallowed = _context.FacilitiesAllowed.Where(x => x.ProviderId == ProviderId);
            // ViewBag.enrollee = _context.Enrollee.Where(x => x.Policynumber == "Policynumber" || x.Mobilenumber == "Mobilenumber" || x.Mobilenumber2 == "Mobilenumber");

            //var providers = _context.Provider 

            // var previousmonth = new DateTime(previousDate.Month);
            // ViewBag.providers = _context.Provider
            //  .Include(l => l.Lga)
            // .Include(s => s.State)
            //.Include(p => p.ProviderServices)
            //    .ToList();

            //return Json(providers);

            if (Id == null)
            {
               // return Content(Notification Found);
            }

            Dashboard dashboard = new Dashboard();
            dashboard.Enrollee = (from b in _context.Enrollees
                                  where b.Policynumber == "NHA-428025498745"
                                  select b).FirstOrDefault();
            dashboard.Provider = (from t in _context.Providers
                                  where t.Id == 1026
                                  select t).FirstOrDefault();
            dashboard.Staff = (from b in _context.Staffs
                               where b.StaffId == "ST1204"
                               select b).FirstOrDefault();

            var CompanyId = _context.Staffs
                       .Where(p => p.StaffId == "ST1204")
                       .Select(p => new { p.CompanyId });

            

            dashboard.Company = (from c in _context.Companies
                                 where c.Id == 1183
                                 select c).FirstOrDefault();
            dashboard.Claim = (from d in _context.Claims
                               where d.ProviderId == ProviderId && d.status == "Captured"
                               select d).FirstOrDefault();
            ViewBag.submittedcount = _context.Claims.Count(x => x.ProviderId == 1026 && x.status == "Vetting");
            ViewBag.submittedsum = _context.Claims.Where(x => x.ProviderId == 1026).Include(c => c.ClaimDrugs).Include(s => s.ClaimServices);

            ViewBag.FacilitiesAllowed = _context.FacilitiesAlloweds.Count(x => x.CompanyPlanId == "12393" && x.ProviderId == "1026" && x.Planid == "3");

            if (ViewBag.FacilitiesAllowed == 0)
            {
                ViewBag.FacilitiesAllowed = "Enrollee cannot access care here";
            }
            else
            {
                ViewBag.FacilitiesAllowed = "Enrollee can access care";
            }



            if (dashboard == null)
            {
               // return Content(Not Found);
            }
            return View(dashboard);




            //  return View(providers);
        }

       
      
    }
}