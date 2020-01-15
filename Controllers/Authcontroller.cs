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
    public class AuthController : ControllerBase
    {
		private readonly DatabaseContext _context;

        public AuthController(DatabaseContext context)
        {
            _context = context;
        }
		// GET: api/Authenticate
        [HttpGet]
        public async Task<ActionResult<Boolean>> Authenticate([FromForm] string login, [FromForm] string password)
        {
			var account = await _context.Account.Where(a => a.Email == login && a.Password == password).FirstOrDefaultAsync();

			if (account == null)
			{
				return false;
			}
			else
			{
				return true;
			}
        }
	}
}