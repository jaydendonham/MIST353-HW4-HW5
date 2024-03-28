using TravelPortalAPI.Repositories;
using TravelPortalAPI.Entities;
using Microsoft.AspNetCore.Mvc;

//Ryan Sladic
namespace TravelPortalAPI.Controllers
        [Route("api/[controller]")]
        [ApiController]
public class VehicleController : ControllerBase
{
 private readonly IVehicleService _vehicleService;

        public VehiclesController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehicles()
        {
            var vehicles = await _vehicleService.GetVehiclesAsync();
            return Ok(vehicles);
        }

    [HttpPost("manufacturer")]
    public IActionResult GetVehiclesByManufacturer([FromBody] ManufacturerInput input)
    {

        var response = $"You requested vehicles manufactured by {input.Manufacturer} manufacturer.";
        return Ok(response);
    }
}
