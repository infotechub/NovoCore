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


        public ActionResult New()
        {
            var state = _context.State.ToList();
            var lga = _context.Lga.ToList();
            var assignee = _context.Users.ToList();
            var viewModel = new ProviderViewModel
            {
                Providers = new Provider(),
                State = state,
                Lga = lga
            };
            return View("ProviderForm", viewModel);
        }

       // [HttpPost]
        public ActionResult Save(Provider provider)
        {

            if (!ModelState.IsValid)
            {
                var viewModel = new ProviderViewModel
                {
                    Providers = provider,
                    State = _context.State.ToList(),
                    Lga = _context.Lga.ToList()
                };
                return View("ProviderForm", viewModel);
            }

            if (provider.Id == 0)
                _context.Provider.Add(provider);
            else
            {
                var providerInDb = _context.Provider.Single(c => c.Id == provider.Id);
                providerInDb.Name = provider.Name;
                providerInDb.Address = provider.Address;
                providerInDb.Area = provider.Area;
                providerInDb.Assignee = provider.Assignee;

            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Providers");
        }

       // [HttpGet]
        public ActionResult Index()
        {

            ViewBag.BillsCaptured = _context.ClaimBatch.Count(x => x.ProviderId == 40985);
            //var providers = _context.Provider 
            ViewBag.providers = _context.Provider
              //  .Include(l => l.Lga)
               // .Include(s => s.State)
                .Include(p => p.ProviderServices)
                .ToList();

            //return Json(providers);
            return View();
        }

      /*  [HttpGet]
        public ActionResult Bills()
        {

            //ViewBag.BillsCaptured = _context.ClaimBatch.Where(x => x.ProviderId == 40985 && y => y. ).ToList();

            var providers = _context.Provider
                .Include(l => l.Lga)
                .Include(s => s.State)
                .Include(p => p.ProviderServices)
                .ToList();

            return View(providers);
        }*/

        [HttpGet("id")]
        public async Task<IActionResult> Details(int id)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Anyprovider = _context.Provider.Include(c => c.ProviderTariffs).SingleOrDefault(c => c.Id == id);

            if (Anyprovider == null)
                return Content("Not Found");

            return View(Anyprovider);

        }

        // GET: api/Providers1/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProvider([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var provider = _context.Provider.Include(p => p.ProvideraccountId).SingleOrDefault(p => p.Id == id);

            if (provider == null)
            {
                return NotFound();
            }

            return View(provider);
        }


        public ActionResult Edit(int id)
        {

            //we need to get the customer details from the database
            var provider = _context.Provider.SingleOrDefault(c => c.Id == id);
            if (provider == null)
                return Content("NOT FOUND");


            var viewModel = new ProviderViewModel
            {
                Providers = provider,
                Lga = _context.Lga.ToList(),
                State = _context.State.ToList()


            };

            return View("ProviderForm", viewModel);


        }
    }
}