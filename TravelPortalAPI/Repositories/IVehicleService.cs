    //Ryan Sladic 
using TravelPortalAPI.Entities;

namespace TravelPortalAPI.Repositories
{
    public interface IVehicleService
    {
        public Task<List<Vehicle>> GetVehicleDetails(string make, string model, int year);
    }
}
