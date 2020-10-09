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
    public class SummaryTotalsController : ControllerBase
    {
        private readonly dbContext _context;

        public SummaryTotalsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/SummaryTotals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SummaryTotal>>> GetsummaryTotals()
        {
            return await _context.summaryTotals.ToListAsync();
        }

        // GET: api/SummaryTotals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SummaryTotal>> GetSummaryTotal(int id)
        {
            var summaryTotal = await _context.summaryTotals.FindAsync(id);

            if (summaryTotal == null)
            {
                return NotFound();
            }

            return summaryTotal;
        }

        // PUT: api/SummaryTotals/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSummaryTotal(int id, SummaryTotal summaryTotal)
        {
            if (id != summaryTotal.StID)
            {
                return BadRequest();
            }

            _context.Entry(summaryTotal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SummaryTotalExists(id))
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

        // POST: api/SummaryTotals
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SummaryTotal>> PostSummaryTotal(SummaryTotal summaryTotal)
        {
            _context.summaryTotals.Add(summaryTotal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSummaryTotal", new { id = summaryTotal.StID }, summaryTotal);
        }

        // DELETE: api/SummaryTotals/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SummaryTotal>> DeleteSummaryTotal(int id)
        {
            var summaryTotal = await _context.summaryTotals.FindAsync(id);
            if (summaryTotal == null)
            {
                return NotFound();
            }

            _context.summaryTotals.Remove(summaryTotal);
            await _context.SaveChangesAsync();

            return summaryTotal;
        }

        private bool SummaryTotalExists(int id)
        {
            return _context.summaryTotals.Any(e => e.StID == id);
        }
    }
}
