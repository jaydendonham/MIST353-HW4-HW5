using TravelPortalAPI.Repositories;
using TravelPortalAPI.Entities;
using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class VehicleController : ControllerBase
{
    [HttpPost("manufacturer")]
    public IActionResult GetVehiclesByManufacturer([FromBody] ManufacturerInput input)
    {
        // Implement logic to process the input
        // For demonstration purposes, we'll just return a sample response
        var response = $"You requested vehicles manufactured by {input.Manufacturer}.";
        return Ok(response);
    }
}
