//Ryan Sladic

using System.Threading.Tasks;
using TravelPortalAPI.Entities;

namespace TravelPortalAPI.Repositories
{
    public interface IVehicleService
    {
        Task<List<Vehicle>> GetVehicleDetails(string make, string model, int year);
    }
}
