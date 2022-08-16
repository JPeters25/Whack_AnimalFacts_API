using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalFacts.Models;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Versioning;



namespace AnimalFacts.Controllers.v1
{
  [ApiController]
  [ApiVersion("1.0")]
  [Route("api/v1/facts")]
  
  public class FactsV1Controller : ControllerBase
  {
    private readonly AnimalFactsContext _db;

    public FactsV1Controller(AnimalFactsContext db)
    {
      _db = db;
    }

     // GET: api/Facts

    [HttpGet]
    [ApiVersion("1.0")]
    public async Task<ActionResult<IEnumerable<Fact>>> Get(string animaltype, string species, string description, string nsfw)
    {
      var query = _db.Facts.AsQueryable();

      if (animaltype != null)
      {
        query = query.Where(entry => entry.AnimalType == animaltype);
      }

      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
      } 

      if (description != null)
      {
        query = query.Where(entry => entry.Description == description);
      }

      if (nsfw != null)
      {
        query = query.Where(entry => entry.Nsfw == nsfw);
      }

      return await query.ToListAsync();
    }

    // GET: api/Facts/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Fact>> GetFact(int id)
    {
        var fact = await _db.Facts.FindAsync(id);

        if (fact == null)
        {
            return NotFound();
        }

        return fact;
    }

    // PUT: api/Facts/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Fact fact)
    {
      if (id != fact.FactId)
      {
        return BadRequest();
      }

      _db.Entry(fact).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!FactsExists(id))
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

    // POST: api/Facts
    [HttpPost]
    public async Task<ActionResult<Fact>> Post(Fact fact)
    {
      _db.Facts.Add(fact);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetFact), new { id = fact.FactId }, fact);
    }

    // DELETE: api/Facts/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteFact(int id)
    {
      var fact = await _db.Facts.FindAsync(id);
      if (fact == null)
      {
        return NotFound();
      }

      _db.Facts.Remove(fact);
      await _db.SaveChangesAsync();

      return NoContent();
    }
    
    private bool FactsExists(int id)
    {
      return _db.Facts.Any(e => e.FactId == id);
    }
  }
}
