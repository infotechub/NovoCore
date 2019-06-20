using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NovoClasses.Models;
using NovoCore.Data;
using NovoCore.ViewModel;

namespace ProviderModule.Controllers
{
    public class ClaimController : Controller
    {
        private ApplicationDbContext _context;
        public ClaimController(ApplicationDbContext context)
        {
            _context = context;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        // [HttpGet]
        //[Route("api/[Controller]")]
        public ViewResult SavedBills(int Id, int ProviderId, string enrolleePolicyNumber, string enrolleeCompanyName, string ServiceDate)
        {
           

            if (Id == null)
            {
                // return Content(Notification Found);
            }

            Bills bills = new Bills();
            bills.ClaimBatch = (from b in _context.ClaimBatches
                                  where b.ProviderId == 1029 && b.status == "Captured"
                                  select b).ToList();
            ViewBag.Payment = (from t in _context.ClaimBatches
                                  where t.ProviderId == 1029 && t.status == "Paid"
                                  select t).ToList();
            var CompanyId = _context.Staffs
                       .Where(p => p.StaffId == "ST1204")
                       .Select(p => new { p.CompanyId });
          
            ViewBag.claimscount = _context.Claims.Count(x => x.ProviderId == 1029);
            ViewBag.submitclaimscount = _context.Claims.Count(x => x.ProviderId == 1029 && x.status == "Vetted");
            ViewBag.claims = _context.Claims.Where(x => x.ProviderId == 1029).Include(c => c.ClaimDrugs).Include(s => s.ClaimServices);
          //  ViewBag.claimsum = _context.Claims.Sum(x => x.ProviderId == 1029).Include(c => c.ClaimDrugs).Include(s => s.ClaimServices);

            ViewBag.FacilitiesAllowed = _context.FacilitiesAlloweds.Count(x => x.CompanyPlanId == "12393" && x.ProviderId == "1029" && x.Planid == "3");

            if (ViewBag.FacilitiesAllowed == 0)
            {
                ViewBag.FacilitiesAllowed = "Enrollee cannot access care here";
            }
            else
            {
                ViewBag.FacilitiesAllowed = "Enrollee can access care";
            }



            if (bills == null)
            {
                // return Content(Not Found);
            }
            return View(bills);




            //  return View(providers);
        }



        // [HttpGet]
        //[Route("api/[Controller]")]
        public ViewResult SubmittedBills(int Id, int ProviderId, string enrolleePolicyNumber, string enrolleeCompanyName, string ServiceDate)
        {


            if (Id == null)
            {
                // return Content(Notification Found);
            }

            Bills bills = new Bills();
            bills.ClaimBatch = (from b in _context.ClaimBatches
                                where b.ProviderId == 1029 && b.status == "Default"
                                select b).ToList();
            ViewBag.Payment = (from t in _context.ClaimBatches
                               where t.ProviderId == 1029 && t.status == "Paid"
                               select t).ToList();
            var CompanyId = _context.Staffs
                       .Where(p => p.StaffId == "ST1204")
                       .Select(p => new { p.CompanyId });

            ViewBag.claimscount = _context.Claims.Count(x => x.ProviderId == 1029);
            ViewBag.submitclaimscount = _context.Claims.Count(x => x.ProviderId == 1029 && x.status == "Vetted");
            ViewBag.claims = _context.Claims.Where(x => x.ProviderId == 1029).Include(c => c.ClaimDrugs).Include(s => s.ClaimServices);
            //ViewBag.claimsum = _context.ClaimDrugs.Sum(x => x.ClaimId == 168479);

            ViewBag.FacilitiesAllowed = _context.FacilitiesAlloweds.Count(x => x.CompanyPlanId == "12393" && x.ProviderId == "1029" && x.Planid == "3");

            if (ViewBag.FacilitiesAllowed == 0)
            {
                ViewBag.FacilitiesAllowed = "Enrollee cannot access care here";
            }
            else
            {
                ViewBag.FacilitiesAllowed = "Enrollee can access care";
            }



            if (bills == null)
            {
                // return Content(Not Found);
            }
            return View(bills);




            //  return View(providers);
        }



    }
}