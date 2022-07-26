using HireMeApi.Data;
using HireMeApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HireMeApi.Controllers;

[ApiController]
[Route("[controller]")]
public class IotDevicesController : ControllerBase
{
    private readonly HireMeApiDbContext _dbContext;

    public IotDevicesController(HireMeApiDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    [HttpGet]
    public async Task<ActionResult<List<IotDevice>>> GetAll()
    {
        return await _dbContext.IotDevices.OrderBy(x => x.Name).ToListAsync();
    }
    
    [HttpGet("{id:guid}")]
    public async Task<ActionResult<IotDevice>> GetSingle(Guid id)
    {
        var iotDevice = await _dbContext.IotDevices.FirstOrDefaultAsync(x => x.Id == id);

        if (iotDevice == null)
        {
            return NotFound();
        }

        return iotDevice;
    }

    [HttpDelete("{id:guid}")]
    public async Task<ActionResult> DeleteSingle(Guid id)
    {
        var device = await _dbContext.IotDevices.FirstOrDefaultAsync(i => i.Id == id);
        if (device == null)
        {
            return NotFound();
        }
        
        _dbContext.IotDevices.Remove(device);
        await _dbContext.SaveChangesAsync();
        return NoContent();
    }
}
