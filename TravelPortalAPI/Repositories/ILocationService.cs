using TravelPortalAPI.Entities;

namespace TravelPortalAPI.Repositories
{
    //Jayden Donham
    public interface ILocationService
    {
        public Task<List<Location>> GetLocationDetails(int locationid, string state, string city, string zipcode);
    }
}