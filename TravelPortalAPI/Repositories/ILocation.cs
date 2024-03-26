namespace TravelPortalAPI.Repositories
{
    public interface ILocation
    {
        public Task<List<Location>> spGetLocationDetails(int locationid);
    }
}