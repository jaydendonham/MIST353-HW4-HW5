using System.Threading.Tasks;
using TravelPortalAPI.Entities;

namespace TravelPortalAPI.Repositories
{
    //Josh Keller
    public interface IPOIService
    {
	public Task<List<POI>> POIRetrieveDetails(string poi_state);
    }

}