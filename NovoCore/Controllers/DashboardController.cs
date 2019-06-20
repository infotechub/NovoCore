using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NovoClasses.Models;
using NovoCore.Data;
using NovoCore.Models;
using NovoCore.ViewModel;

namespace NovoCore.Controllers
{
    //[Route("api/[Controller]")]
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
        public ViewResult Index(int ProviderId, string StaffId, string Policynumber, string Mobilenumber, string StaffFullname)
        {
            var previousDate = DateTime.Now.AddMonths(-1);
            var date = new DateTime(previousDate.Year, previousDate.Month, DateTime.Now.Day);
            var providers = _context.Providers.Where(x => x.Id == 1029);
            // ViewBag.providers = _context.Provider.Where(x => x.Id == 1029);
            //ViewBag.claimbatches = _context.ClaimBatch.Where(x => x.ProviderId == ProviderId);
            // ViewBag.claim = _context.Claim.Where(x => x.ProviderId == ProviderId).Include(c => c.ClaimDrugs).Include(s => s.ClaimServices);
            ViewBag.subittedcount = _context.Claims.Count(x => x.ProviderId == 1029 && x.status == "Vetting");
            ViewBag.savedcount = _context.Claims.Count(x => x.ProviderId == 1029 && x.status == "Captured");
            ViewBag.facilitiesallowed = _context.FacilitiesAlloweds;
            ViewBag.enrollee = _context.Enrollees.Where(x => x.Policynumber == "Policynumber" || x.Mobilenumber == "Mobilenumber" || x.Mobilenumber2 == "Mobilenumber");
            ViewBag.ClaimBatch = _context.Claims.Where(x => x.ProviderId == 1029).Include(c => c.ClaimDrugs).Include(s => s.ClaimServices);
           // {
             //   Enrollee = _context.Enrollees.Where(x => x.Policynumber == "Policynumber" || x.Mobilenumber == "Mobilenumber" || x.Mobilenumber2 == "Mobilenumber"),
            //    Staff = _context.Staffs.Where(x => x.StaffId == "StaffId" || x.StaffFullname == "StaffFullname"),
            //    claimBatches = _context.ClaimBatches.Where(x => x.ProviderId == 1029),
           //     Claims = _context.Claims.Where(x => x.ProviderId == 1029).Include(c => c.ClaimDrugs).Include(s => s.ClaimServices)

         //   };
            //var providers = _context.Provider 

            // var previousmonth = new DateTime(previousDate.Month);
            // ViewBag.providers = _context.Provider
            //  .Include(l => l.Lga)
            // .Include(s => s.State)
            //.Include(p => p.ProviderServices)
            //    .ToList();

            //return Json(providers);
            return View();
        }



    }
}