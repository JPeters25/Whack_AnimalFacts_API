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



namespace AnimalFacts.Controllers
{
  [ApiController]
  [ApiVersion("2.0")]
  [Route("api/{version:apiVersion}/Fact")]
  
  public class FactsV2Controller : ControllerBase
  {
    private readonly AnimalFactsContextV2 _db;

    public FactsV2Controller(AnimalFactsContextV2 db)
    {
      _db = db;
    }

    [HttpGet]
    [ApiVersion("2.0")]
    public async Task<ActionResult<IEnumerable<Fact>>> Get(string nsfw)
    {
       var query = _db.Facts.AsQueryable();

          return await query.ToListAsync();
    }
  }
}