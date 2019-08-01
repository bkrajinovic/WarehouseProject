using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Warehouse.Controllers
{
    [Route("api/cities")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
       private readonly WarehouseContext _context;

       public CitiesController(WarehouseContext context)
       {
           _context = context;

       }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<City>>> GetCities()
        {
            return await _context.Cities.ToListAsync();
        }
        
// GET: api/Todo/5
[HttpGet("{id}")]
public async Task<ActionResult<City>> GetCity(int id)
{
    var city = await _context.Cities.FindAsync(id);

    if (city == null)
    {
        return NotFound();
    }

    return city;
}


[HttpPost]
public async Task<IActionResult> PostCity(City item)
{
    _context.Cities.Add(item);
    await _context.SaveChangesAsync();
    return StatusCode(201);
}


[HttpPut("{id}")]
public async Task<IActionResult> PutCity(int id, [FromBody] City item)
{
    item.Id = id;
    _context.Entry(item).State = EntityState.Modified;
    await _context.SaveChangesAsync();

    return NoContent();
}

// DELETE: api/Todo/5
[HttpDelete("{id}")]
public async Task<IActionResult> DeleteCity(int id)
{
    var City = await _context.Cities.FindAsync(id);

    if (City == null)
    {
        return NotFound();
    }

    _context.Cities.Remove(City);
    await _context.SaveChangesAsync();

    return NoContent();
}
}
}
