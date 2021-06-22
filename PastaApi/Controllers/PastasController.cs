using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PastaApi.Models;

namespace PastaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PastasController : ControllerBase
    {
        private readonly PastaApiContext _context;

        public PastasController(PastaApiContext context)
        {
            _context = context;
        }

        // GET: api/Pastas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pasta>>> GetPastas()
        {
            return await _context.Pastas.ToListAsync();
        }

        // GET: api/Pastas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pasta>> GetPasta(int id)
        {
            var pasta = await _context.Pastas.FindAsync(id);

            if (pasta == null)
            {
                return NotFound();
            }

            return pasta;
        }

        // PUT: api/Pastas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPasta(int id, Pasta pasta)
        {
            if (id != pasta.PastaId)
            {
                return BadRequest();
            }

            _context.Entry(pasta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PastaExists(id))
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

        // POST: api/Pastas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pasta>> PostPasta(Pasta pasta)
        {
            _context.Pastas.Add(pasta);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPasta), new { id = pasta.PastaId }, pasta);
        }

        // DELETE: api/Pastas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePasta(int id)
        {
            var pasta = await _context.Pastas.FindAsync(id);
            if (pasta == null)
            {
                return NotFound();
            }

            _context.Pastas.Remove(pasta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PastaExists(int id)
        {
            return _context.Pastas.Any(e => e.PastaId == id);
        }
    }
}

