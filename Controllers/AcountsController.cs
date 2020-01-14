using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using heal_fit.Models;

namespace heal_fit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcountsController : ControllerBase
    {
        private readonly AcountContext _context;

        public AcountsController(AcountContext context)
        {
            _context = context;
        }

        // GET: api/Acounts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Acount>>> GetAcounts()
        {
            return await _context.Acount.ToListAsync();
        }

        // GET: api/Acounts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Acount>> GetAcount(int id)
        {
            var acount = await _context.Acount.FindAsync(id);

            if (acount == null)
            {
                return NotFound();
            }

            return acount;
        }

        // PUT: api/Acounts/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAcount(int id, [FromForm] Acount acount)
        {
            if (id != acount.ID)
            {
                return BadRequest();
            }

            _context.Entry(acount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AcountExists(id))
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

        // POST: api/Acounts
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Acount>> PostAcount([FromForm]Acount acount)
        {
            _context.Acount.Add(acount);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAcount", new { id = acount.ID }, acount);
        }

        // DELETE: api/Acounts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Acount>> DeleteAcount(int id)
        {
            var acount = await _context.Acount.FindAsync(id);
            if (acount == null)
            {
                return NotFound();
            }

            _context.Acount.Remove(acount);
            await _context.SaveChangesAsync();

            return acount;
        }

        private bool AcountExists(int id)
        {
            return _context.Acount.Any(e => e.ID == id);
        }
    }
}
