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
    public class Claims1Controller : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Claims1Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Claims1
        [HttpGet]
        public IEnumerable<Claim> GetClaims()
        {
            return _context.Claims;
        }

        // GET: api/Claims1/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClaim([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var claim = await _context.Claims.FindAsync(id);

            if (claim == null)
            {
                return NotFound();
            }

            return Ok(claim);
        }

        // PUT: api/Claims1/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClaim([FromRoute] int id, [FromBody] Claim claim)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != claim.Id)
            {
                return BadRequest();
            }

            _context.Entry(claim).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClaimExists(id))
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

        // POST: api/Claims1
        [HttpPost]
        public async Task<IActionResult> PostClaim([FromBody] Claim claim)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Claims.Add(claim);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClaim", new { id = claim.Id }, claim);
        }

        // DELETE: api/Claims1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClaim([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var claim = await _context.Claims.FindAsync(id);
            if (claim == null)
            {
                return NotFound();
            }

            _context.Claims.Remove(claim);
            await _context.SaveChangesAsync();

            return Ok(claim);
        }

        private bool ClaimExists(int id)
        {
            return _context.Claims.Any(e => e.Id == id);
        }
    }
}