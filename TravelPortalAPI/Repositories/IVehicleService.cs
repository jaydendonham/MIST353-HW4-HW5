//Ryan Sladic 
using System.Threading.Tasks;
using TravelPortalAPI.Entities;


namespace TravelPortalAPI.Repositories
{
    public interface IVehicleService
    {
        public Task<List<Vehicle>> GetVehicleDetails(int VIN, string VMake, string VModel, string VYear);
    }
}
