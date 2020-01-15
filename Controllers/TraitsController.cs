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
    public class TraitsController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public TraitsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Traits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Trait>>> GetTrait()
        {
            return await _context.Trait.ToListAsync();
        }

        // GET: api/Traits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Trait>> GetTrait(long id)
        {
            var trait = await _context.Trait.FindAsync(id);

            if (trait == null)
            {
                return NotFound();
            }

            return trait;
        }

        // PUT: api/Traits/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrait(long id, [FromForm] Trait trait)
        {
            if (id != trait.ID)
            {
                return BadRequest();
            }

            _context.Entry(trait).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TraitExists(id))
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

        // POST: api/Traits
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Trait>> PostTrait([FromForm] Trait trait)
        {
            _context.Trait.Add(trait);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTrait", new { id = trait.ID }, trait);
        }

        // DELETE: api/Traits/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Trait>> DeleteTrait(long id)
        {
            var trait = await _context.Trait.FindAsync(id);
            if (trait == null)
            {
                return NotFound();
            }

            _context.Trait.Remove(trait);
            await _context.SaveChangesAsync();

            return trait;
        }

        private bool TraitExists(long id)
        {
            return _context.Trait.Any(e => e.ID == id);
        }
    }
}
