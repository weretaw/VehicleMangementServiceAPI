using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VehicleMangementService.Models;

namespace VehicleMangementService.Controllers
{
  [Route("api/[controller]")]
  public class VehiclesController : Controller
  {
    private readonly VehicleContext _context;

    public VehiclesController(VehicleContext context)
    {
      _context = context;
    }

    // GET: api/Vehicles
    /// <summary>
    /// This is get all vehicles
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehicles()
    {
      return await _context.Vehicles.ToListAsync();
    }

    // GET: api/Vehicles/5
    /// <summary>
    /// This get by specific ID
    /// </summary>
    /// <param name="id">Mandatory</param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<Vehicle>> GetVehicle(int id)
    {
      var vehicle = await _context.Vehicles.FindAsync(id);

      if (vehicle == null)
      {
        return NotFound();
      }

      return vehicle;
    }

    // PUT: api/Vehicles/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutCategory(int id, Vehicle vehicle)
    {
      if (id != vehicle.VehicleId)
      {
        return BadRequest();
      }

      _context.Entry(vehicle).State = EntityState.Modified;

      try
      {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!VehicleExists(id))
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
    // POST: api/Vehicles
    /// <summary>
    /// This is post method
    /// </summary>
    /// <param name="vehicle"></param>
    /// <returns>Vehicle</returns>
    [HttpPost]
    public async Task<ActionResult<Vehicle>> PostCategory(Vehicle vehicle)
    {
      _context.Vehicles.Add(vehicle);
      await _context.SaveChangesAsync();

      return CreatedAtAction("GetVehicle", new { id = vehicle.VehicleId }, vehicle);
    }

    // DELETE: api/Vehicles/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<Vehicle>> DeleteVehicle(int id)
    {
      var vehicle = await _context.Vehicles.FindAsync(id);
      if (vehicle == null)
      {
        return NotFound();
      }

      _context.Vehicles.Remove(vehicle);
      await _context.SaveChangesAsync();

      return vehicle;
    }

  

    private bool VehicleExists(int id)
        {
            return _context.Vehicles.Any(e => e.VehicleId == id);
        }
    }
}
