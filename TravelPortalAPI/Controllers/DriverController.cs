using TravelPortalAPI.Repositories;
using TravelPortalAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

//Josh Keller
namespace TravelPortalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : Controller
    {

        public async Task<ActionResult<int>> AddDriver(Driver drive)
	{
	var driverDetails = await driverService.AddDriver(driver);
	return driverDetails;
	}

    }
}
