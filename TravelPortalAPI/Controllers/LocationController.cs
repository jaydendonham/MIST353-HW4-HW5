using TravelPortalAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace TravelPortalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : Controller
    {
        private readonly ILocation locationservice;
            public LocationController(ILocation locationService)
        {
            this.locationservice = locationService;
        }
        [HttpGet("{locationId}")]
        public async Task<List<Location>> GetLocationDetails(int locationId)
        {
            var locationDetails = await location.GetLocationDetails(locationId);
            return locationDetails;
        }
