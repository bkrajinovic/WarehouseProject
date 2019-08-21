using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Warehouse.Controllers
{
    
    [Route("api/employees")]
    [ApiController]
    
    public class EmployeesController : ControllerBase
    {
       private readonly WarehouseContext _context;

       public EmployeesController(WarehouseContext context)
       {
           _context = context;

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            return await _context.Employees.Include(w => w.Warehouse).ToListAsync();
        }
        
        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
        var employee = await _context.Employees.Include(w => w.Warehouse).FirstAsync(a => a.Id == id);

        if (employee == null)
        {
            return NotFound();
        }

        return employee;
        }
        [HttpPost]
        public async Task<IActionResult> PostEmployee(Employee item)
        {
        _context.Employees.Add(item);
        await _context.SaveChangesAsync();
        return StatusCode(201);
        }


[HttpPut("{id}")]
public async Task<IActionResult> PutEmployee(int id, [FromBody] Employee item)
{
    item.Id = id;
    _context.Entry(item).State = EntityState.Modified;
    await _context.SaveChangesAsync();

    return NoContent();
}

[HttpDelete("{id}")]
public async Task<IActionResult> DeleteEmployee(int id)
{
    var Employee = await _context.Employees.FindAsync(id);

    if (Employee == null)
    {
        return NotFound();
    }

    _context.Employees.Remove(Employee);
    await _context.SaveChangesAsync();

    return NoContent();
}

    }
}


    
