using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NovoCore.Data;

namespace ProviderModule.Controllers
{
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

        public ActionResult Index()
        {

            ViewBag.BillsCaptured = _context.ClaimBatch.Count(x => x.ProviderId == 40985);
            //var providers = _context.Provider 
            ViewBag.providers = _context.Provider
                .Include(l => l.Lga)
                .Include(s => s.State)
                .Include(p => p.ProviderServices)
                .ToList();

            //return Json(providers);
            return View();
        }
    }
}