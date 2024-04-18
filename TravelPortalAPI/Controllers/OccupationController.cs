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
        [HttpGet("{OccupationID}/{Position}/{Wage}")]
        public async Task<List<Occupation>> GetOccupationDetails(int OccupationID, string Position, double Wage)
        {
            var OccupationDetails = await occupationservice.GetOccupationDetails(OccupationID, Position, Wage);
            return OccupationDetails;

        }
    }
}
