using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Warehouse.Controllers
{
    [Route("api/goods")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
       private readonly WarehouseContext _context;

       public GoodsController(WarehouseContext context)
       {
           _context = context;

       }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Goods>>> GetGoods()
        {
            return await _context.Goods.Include(w => w.Warehouse).ToListAsync();
        }
        
// GET: api/Todo/5
[HttpGet("{id}")]
public async Task<ActionResult<Goods>> GetGoods(int id)
{
    var Goods = await _context.Goods.Include(w => w.Warehouse).FirstAsync(a => a.Id == id);

    if (Goods == null)
    {
        return NotFound();
    }

    return Goods;
}


[HttpPost]
public async Task<IActionResult> PostGoods(Goods item)
{
    _context.Goods.Add(item);
    await _context.SaveChangesAsync();
    return StatusCode(201);
}

[HttpPut("{id}")]
public async Task<IActionResult> PutGoods(int id, [FromBody] Goods item)
{
    item.Id = id;
    _context.Entry(item).State = EntityState.Modified;
    await _context.SaveChangesAsync();

    return NoContent();
}

[HttpDelete("{id}")]
public async Task<IActionResult> DeleteGoods(int id)
{
    var Goods = await _context.Goods.FindAsync(id);

    if (Goods == null)
    {
        return NotFound();
    }

    _context.Goods.Remove(Goods);
    await _context.SaveChangesAsync();

    return NoContent();
}
}
}
