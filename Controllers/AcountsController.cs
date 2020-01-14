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
    public class AccountsController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public AccountsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Acounts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Account>>> GetAcounts()
        {
            return await _context.Account.ToListAsync();
        }

        // GET: api/Acounts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Account>> GetAcount(int id)
        {
            var acount = await _context.Account.FindAsync(id);

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
        public async Task<ActionResult<Account>> PutAcount(int id, [FromForm] Account account)
        {
            if (id != account.ID)
            {
                return BadRequest();
            }

            _context.Entry(account).State = EntityState.Modified;

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

            return account;
        }

        // POST: api/Acounts
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Account>> PostAcount([FromForm]Account account)
        {
            _context.Account.Add(account);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAcount", new { id = account.ID }, account);
        }

        // DELETE: api/Acounts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Account>> DeleteAcount(int id)
        {
            var account = await _context.Account.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }

            _context.Account.Remove(account);
            await _context.SaveChangesAsync();

            return account;
        }

        private bool AcountExists(int id)
        {
            return _context.Account.Any(e => e.ID == id);
        }
    }
}
