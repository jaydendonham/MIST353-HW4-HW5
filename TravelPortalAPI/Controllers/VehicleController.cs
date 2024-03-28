using TravelPortalAPI.Repositories;
using TravelPortalAPI.Entities;
using Microsoft.AspNetCore.Mvc;

//Ryan Sladic
namespace TravelPortalAPI.Controllers
        [Route("api/[controller]")]
        [ApiController]
public class VehicleController : ControllerBase
{
    [HttpPost("manufacturer")]
    public IActionResult GetVehiclesByManufacturer([FromBody] ManufacturerInput input)
    {

        var response = $"You requested vehicles manufactured by {input.Manufacturer} manufacturer.";
        return Ok(response);
    }
}
