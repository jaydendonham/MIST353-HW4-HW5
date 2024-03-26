namespace TravelPortalAPI.Repositories
{
    //Jayden Donham
    public interface ILocation
    {
        public Task<List<Location>> GetLocationDetails(int locationid);
    }
}