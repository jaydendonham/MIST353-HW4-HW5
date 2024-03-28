using TravelPortalAPI.Entities;

namespace TravelPortalAPI.Repositories
{
    //Jayden Donham
    public interface IOccupationService
    {
        public Task<List<Occupation>> GetOccupationDetails(int occupationid, string position, double wage);
    }
}