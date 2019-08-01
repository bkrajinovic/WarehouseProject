using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Warehouse.Controllers
{
    [Route("api/warehouses")]
    [ApiController]
    public class WarehousesController : ControllerBase
    {
       private readonly WarehouseContext _context;

       public WarehousesController(WarehouseContext context)
       {
           _context = context;

           
       }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Warehouse>>> GetWarehouses()
        {
            
            return await _context.Warehouses.ToListAsync();
        }
        

[HttpGet("{id}")]
public async Task<ActionResult<Warehouse.Models.Warehouse>> GetWarehouse(int id)
{
    var Warehouse = await _context.Warehouses.FindAsync(id);

    if (Warehouse == null)
    {
        return NotFound();
    }

    return Warehouse;
}


[HttpPost]
public async Task<IActionResult> PostWarehouse(Warehouse.Models.Warehouse item)
{
    _context.Warehouses.Add(item);
    await _context.SaveChangesAsync();
    return StatusCode(201);
}


[HttpPut("{id}")]
public async Task<IActionResult> PutWarehouse(int id, [FromBody] Warehouse.Models.Warehouse item)
{
    item.Id = id;
    _context.Entry(item).State = EntityState.Modified;
    await _context.SaveChangesAsync();

    return NoContent();
}

[HttpDelete("{id}")]
public async Task<IActionResult> DeleteWarehouse(int id)
{
    var Warehouse = await _context.Warehouses.FindAsync(id);

    if (Warehouse == null)
    {
        return NotFound();
    }

    _context.Warehouses.Remove(Warehouse);
    await _context.SaveChangesAsync();

    return NoContent();
}
}
}
