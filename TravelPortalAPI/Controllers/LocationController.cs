using TravelPortalAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

//Jayden Donham
namespace TravelPortalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : Controller
    {
        private readonly ILocation locationservice;
        public LocationController(ILocation location)
        {
            this.Location = location;
        }
        [HttpGet("{locationId}")]
        public async Task<List<Location>> GetLocationDetails(int locationId)
        {
            var LocationDetails = await Location.GetLocationDetails(locationId);
            return LocationDetails;
        }
    }
}
