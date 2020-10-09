using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorldOmeterAPI.Models;

namespace WorldOmeterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SummmaryCasesController : ControllerBase
    {
        private readonly dbContext _context;

        public SummmaryCasesController(dbContext context)
        {
            _context = context;
        }

        // GET: api/SummmaryCases
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SummmaryCases>>> GetsummaryCases()
        {
            return await _context.summaryCases.ToListAsync();
        }

        // GET: api/SummmaryCases/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SummmaryCases>> GetSummmaryCases(int id)
        {
            var summmaryCases = await _context.summaryCases.FindAsync(id);

            if (summmaryCases == null)
            {
                return NotFound();
            }

            return summmaryCases;
        }

        // PUT: api/SummmaryCases/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSummmaryCases(int id, SummmaryCases summmaryCases)
        {
            if (id != summmaryCases.ScID)
            {
                return BadRequest();
            }

            _context.Entry(summmaryCases).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SummmaryCasesExists(id))
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

        // POST: api/SummmaryCases
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SummmaryCases>> PostSummmaryCases(SummmaryCases summmaryCases)
        {
            _context.summaryCases.Add(summmaryCases);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSummmaryCases", new { id = summmaryCases.ScID }, summmaryCases);
        }

        // DELETE: api/SummmaryCases/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SummmaryCases>> DeleteSummmaryCases(int id)
        {
            var summmaryCases = await _context.summaryCases.FindAsync(id);
            if (summmaryCases == null)
            {
                return NotFound();
            }

            _context.summaryCases.Remove(summmaryCases);
            await _context.SaveChangesAsync();

            return summmaryCases;
        }

        private bool SummmaryCasesExists(int id)
        {
            return _context.summaryCases.Any(e => e.ScID == id);
        }
    }
}
