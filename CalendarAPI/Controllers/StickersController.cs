using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CalendarAPI;
using CalendarAPI.Context;

namespace CalendarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StickersController : ControllerBase
    {
        private readonly CalendarDbContext _context;

        public StickersController(CalendarDbContext context)
        {
            _context = context;
        }

        // GET: api/Stickers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stickers>>> GetStickers()
        {
            return await _context.Stickers.ToListAsync();
        }
            

        // GET: api/Stickers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Stickers>> GetStickers(int id)
        {
            var stickers = await _context.Stickers.FindAsync(id);

            if (stickers == null)
            {
                return NotFound();
            }

            return stickers;
        }

        // PUT: api/Stickers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStickers(int id, Stickers stickers)
        {
            if (id != stickers.Id)
            {
                return BadRequest();
            }

            _context.Entry(stickers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StickersExists(id))
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

        // POST: api/Stickers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Stickers>> PostStickers(Stickers stickers)
        {
            _context.Stickers.Add(stickers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStickers", new { id = stickers.Id }, stickers);
        }

        // DELETE: api/Stickers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStickers(int id)
        {
            var stickers = await _context.Stickers.FindAsync(id);
            if (stickers == null)
            {
                return NotFound();
            }

            _context.Stickers.Remove(stickers);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StickersExists(int id)
        {
            return _context.Stickers.Any(e => e.Id == id);
        }
    }
}
