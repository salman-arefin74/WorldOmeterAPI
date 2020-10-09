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
    public class CountryViewsController : ControllerBase
    {
        private readonly dbContext _context;

        public CountryViewsController(dbContext context)
        {
            _context = context;
        }

        // GET: api/CountryViews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CountryView>>> GetcountryViews()
        {
            return await _context.countryViews.ToListAsync();
        }

        // GET: api/CountryViews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CountryView>> GetCountryView(int id)
        {
            var countryView = await _context.countryViews.FindAsync(id);

            if (countryView == null)
            {
                return NotFound();
            }

            return countryView;
        }

        // PUT: api/CountryViews/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCountryView(int id, CountryView countryView)
        {
            if (id != countryView.CvID)
            {
                return BadRequest();
            }

            _context.Entry(countryView).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountryViewExists(id))
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

        // POST: api/CountryViews
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CountryView>> PostCountryView(CountryView countryView)
        {
            _context.countryViews.Add(countryView);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCountryView", new { id = countryView.CvID }, countryView);
        }

        // DELETE: api/CountryViews/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CountryView>> DeleteCountryView(int id)
        {
            var countryView = await _context.countryViews.FindAsync(id);
            if (countryView == null)
            {
                return NotFound();
            }

            _context.countryViews.Remove(countryView);
            await _context.SaveChangesAsync();

            return countryView;
        }

        private bool CountryViewExists(int id)
        {
            return _context.countryViews.Any(e => e.CvID == id);
        }
    }
}
