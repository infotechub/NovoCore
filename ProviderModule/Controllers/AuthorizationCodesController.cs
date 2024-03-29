﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NovoCore.Data;
using NovoCore.ViewModel;

namespace ProviderModule.Controllers
{
    [EnableCors("AllowOrigin")]
    public class CodesController : Controller
    {
        private ApplicationDbContext _context;
        public CodesController(ApplicationDbContext context)
        {
            _context = context;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult AuthorizationCodes(int Id, int ProviderId, string enrolleePolicyNumber, string enrolleeCompanyName, string ServiceDate)
        {


            if (Id == null)
            {
                // return Content(Notification Found);
            }

            CodesViewModel codesviewmodel= new CodesViewModel();
            codesviewmodel.AuthorizationCodes = (from b in _context.AuthorizationCodes
                                where b.provider == 1029 && b.status == "Captured"
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



           // if (bills == null)
            {
                // return Content(Not Found);
            }
            return View();




            //  return View(providers);
        }
    }
}