using System.Threading.Tasks;
using TravelPortalAPI.Entities;

namespace TravelPortalAPI.Repositories
{
    //Josh Keller
    public interface IPOI
    {
	public Task<List<POI>> POIRetrieveDetails(string poi_state);
    }

}