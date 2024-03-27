using System.Threading.Tasks;
using TravelPortalAPI.Entities;

namespace TravelPortalAPI.Repositories
{
    //Josh Keller
    public interface IDriver
    {
	public Task<List<Driver>> DriverRetrieveDetails(int did);
	public Task<int> AddDriver(Driver driver);
    }

}