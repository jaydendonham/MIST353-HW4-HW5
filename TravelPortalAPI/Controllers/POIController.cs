using TravelPortalAPI.Repositories;
using TravelPortalAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

//Josh Keller
namespace TravelPortalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class POIController : Controller
    {
	private readonly IPOIService poiService;
	public POIController(IPOIService poiService)
	{
		this.poiService = poiService;
	}

	[HttpGet("{POI_State}")]
	public async Task<List><POI>> POIRetrieveDetails(string poi_state)
	{
		var poiDetails = await poiService.POIRetrieveDetails(poi_state);
		//potential if statement here
		return poiDetails;
	}
    }
}
