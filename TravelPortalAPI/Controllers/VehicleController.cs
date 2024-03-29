using TravelPortalAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using TravelPortalAPI.Entities;

//Ryan Sladic
namespace TravelPortalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : Controller
    {
        private readonly IVehicleService vehicleservice;
        public VehicleController(IVehicleService vehicle)
        {
            this.vehicleservice = vehicle;
        }
        [HttpGet("{vehicleId}")]
        public async Task<List<Vehicle>> GetVehicleDetails(int VIN, string VMake, string VModel, string VYear)
        {
            var VehicleDetails = await vehicleservice.GetVehicleDetails(VIN, VMake, VModel, VYear);
            return VehicleDetails;
        }
    }
}
