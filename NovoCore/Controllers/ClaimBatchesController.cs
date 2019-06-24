using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NovoClasses.Models;
using NovoCore.Data;

namespace NovoCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimBatchesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ClaimBatchesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ClaimBatches
        [HttpGet]
        public IEnumerable<ClaimBatch> GetClaimBatches()
        {
           // var ClaimBatch = _context.ClaimBatches.Where(p => p.ProviderId == 1029).ToList();
            return _context.ClaimBatches.Where(p => p.ProviderId == 1029).ToList();
        }

        // GET: api/ClaimBatches/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClaimBatch([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var claimBatch = await _context.ClaimBatches.FindAsync(id);

            if (claimBatch == null)
            {
                return NotFound();
            }

            return Ok(claimBatch);
        }

        // PUT: api/ClaimBatches/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClaimBatch([FromRoute] int id, [FromBody] ClaimBatch claimBatch)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != claimBatch.Id)
            {
                return BadRequest();
            }

            _context.Entry(claimBatch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClaimBatchExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ClaimBatches
        [HttpPost]
        public async Task<IActionResult> PostClaimBatch([FromBody] ClaimBatch claimBatch)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ClaimBatches.Add(claimBatch);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClaimBatch", new { id = claimBatch.Id }, claimBatch);
        }

        // DELETE: api/ClaimBatches/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClaimBatch([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var claimBatch = await _context.ClaimBatches.FindAsync(id);
            if (claimBatch == null)
            {
                return NotFound();
            }

            _context.ClaimBatches.Remove(claimBatch);
            await _context.SaveChangesAsync();

            return Ok(claimBatch);
        }

        private bool ClaimBatchExists(int id)
        {
            return _context.ClaimBatches.Any(e => e.Id == id);
        }
    }
}