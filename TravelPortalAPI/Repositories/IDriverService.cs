using System.Threading.Tasks;
using TravelPortalAPI.Entities;

namespace TravelPortalAPI.Repositories
{
    //Josh Keller
    public interface IDriver
    {
	//public Task<List<Driver>> DriverRetrieveDetails(int did);
	//Commented out because there was never a find driver function finished
	//Just here because it probably will be implemented in Assignment 5 or the final project
	public Task<int> AddDriver(Driver driver);
    }

}