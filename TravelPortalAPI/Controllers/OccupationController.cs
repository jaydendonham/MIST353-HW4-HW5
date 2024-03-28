using TravelPortalAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using TravelPortalAPI.Entities;

//Jayden Donham
namespace TravelPortalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OccupationController : Controller
    {
        private readonly IOccupationService occupationservice;
        public OccupationController(IOccupationService occupation)
        {
            this.occupationservice = occupation;
        }
        [HttpGet("{occupationId}/{startDate}/{endDate}")]
        public async Task<List<Occupation>> GetOccupationDetails(int occupationid, string position, double wage)
        {
            var OccupationDetails = await occupationservice.GetOccupationDetails(occupationid, position, wage);
            return OccupationDetails;

        }
    }
}
