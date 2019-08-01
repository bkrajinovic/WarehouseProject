using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Warehouse.Controllers
{
    [Route("api/positions")]
    [ApiController]
    public class PositionsController : ControllerBase
    {
       private readonly WarehouseContext _context;

       public PositionsController(WarehouseContext context)
       {
           _context = context;

       }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Position>>> GetPosition()
        {
            return await _context.Positions.ToListAsync();
        }
        
// GET: api/Todo/5
[HttpGet("{id}")]
public async Task<ActionResult<Position>> GetPositions(int id)
{
    var Position = await _context.Positions.FindAsync(id);

    if (Position == null)
    {
        return NotFound();
    }

    return Position;
}


[HttpPost]
public async Task<IActionResult> PostPosition(Position item)
{
    _context.Positions.Add(item);
    await _context.SaveChangesAsync();
    return StatusCode(201);
}


[HttpPut("{id}")]
public async Task<IActionResult> PutPosition(int id, [FromBody] Position item)
{
    item.Id = id;
    _context.Entry(item).State = EntityState.Modified;
    await _context.SaveChangesAsync();

    return NoContent();
}

[HttpDelete("{id}")]
public async Task<IActionResult> DeletePosition(int id)
{
    var Position = await _context.Positions.FindAsync(id);

    if (Position == null)
    {
        return NotFound();
    }

    _context.Positions.Remove(Position);
    await _context.SaveChangesAsync();

    return NoContent();
}
}
}
