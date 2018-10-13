using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShoppingWebsite.Models;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EdminsController : ControllerBase
    {
        private readonly WebApplication2Context _context;

        public EdminsController(WebApplication2Context context)
        {
            _context = context;
        }

        // GET: api/Edmins
        [HttpGet]
        public IEnumerable<Edmin> GetEdmin()
        {
            return _context.Edmin;
        }

        // GET: api/Edmins/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEdmin([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var edmin = await _context.Edmin.FindAsync(id);

            if (edmin == null)
            {
                return NotFound();
            }

            return Ok(edmin);
        }

        // PUT: api/Edmins/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEdmin([FromRoute] int id, [FromBody] Edmin edmin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != edmin.edminId)
            {
                return BadRequest();
            }

            _context.Entry(edmin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EdminExists(id))
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

        // POST: api/Edmins
        [HttpPost]
        public async Task<IActionResult> PostEdmin([FromBody] Edmin edmin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Edmin.Add(edmin);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEdmin", new { id = edmin.edminId }, edmin);
        }

        // DELETE: api/Edmins/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEdmin([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var edmin = await _context.Edmin.FindAsync(id);
            if (edmin == null)
            {
                return NotFound();
            }

            _context.Edmin.Remove(edmin);
            await _context.SaveChangesAsync();

            return Ok(edmin);
        }

        private bool EdminExists(int id)
        {
            return _context.Edmin.Any(e => e.edminId == id);
        }
    }
}