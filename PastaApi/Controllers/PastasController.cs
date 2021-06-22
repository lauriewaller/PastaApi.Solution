using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PastaApi.Models;
using System.Linq;


namespace PastaApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PastasController : ControllerBase
  {
    private readonly PastaApiContext _db;

    public PastasController(PastaApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Pasta>>> Get()
    {
      return await _db.Pastas.ToListAsync();
    }
    [HttpPost]
    public async Task<ActionResult<Pasta>> Post(Pasta pasta)
    {
      _db.Pastas.Add(pasta);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = pasta.PastaId }, pasta);
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Pasta>> GetPasta(int id)
    {
        var pasta = await _db.Pastas.FindAsync(id);

        if (pasta == null)
        {
            return NotFound();
        }

        return pasta;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Pasta pasta)
    {
      if (id != pasta.PastaId)
      {
        return BadRequest();
      }

      _db.Entry(pasta).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
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

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePasta(int id)
    {
      var pasta = await _db.Pastas.FindAsync(id);
      if (pasta == null)
      {
        return NotFound();
      }

      _db.Pastas.Remove(pasta);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool PastaExists(int id)
    {
      return _db.Pastas.Any(e => e.PastaId == id);
    }
  }
}