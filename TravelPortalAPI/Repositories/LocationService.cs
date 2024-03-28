using TravelPortalAPI.Data;
using TravelPortalAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

//Jayden Donham
namespace TravelPortalAPI.Repositories
{
    public class LocationService : ILocationService
    {
        private readonly DbContextClass _dbContextClass;

        public LocationService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<List<Entities.Location>> GetLocationDetails(int locationid)
        {
            var param = new SqlParameter("@LocationID", locationid);

            var locationDetails = await _dbContextClass.Location
                .FromSqlRaw("EXEC spLocationDetails @LocationID", param)
                .ToListAsync();

            return locationDetails;
        }
    }
}
