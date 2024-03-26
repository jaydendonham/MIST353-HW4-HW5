using TravelPortalAPI.Data;
using TravelPortalAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

//Jayden Donham
namespace TravelPortalAPI.Repositories
{
    public class Location : ILocation
    {
        private readonly DbContextClass _dbContextClass;
        
        public Location(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<Location>> GetLocationDetails(int locationid)
        {
            var param = new SqlParameter("@LocationID", locationid);
            var LocationDetails = await Task.Run(() => _dbContextClass.Location.FromSqlRaw("exec spGetLocationDetails @CompanyID", param).ToListAsync());
            return LocationDetails;
        }
    }
}
