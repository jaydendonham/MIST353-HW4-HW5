using TravelPortalAPI.Data;
using TravelPortalAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

//Jayden Donham
namespace TravelPortalAPI.Repositories
{
    public class OccupationService : IOccupationService
    {
        private readonly DbContextClass _dbContextClass;

        public OccupationService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<List<Entities.Occupation>> GetOccupationDetails(int occupationid, string position, double wage)
        {
            var param = new SqlParameter("@OccupationID", occupationid);
            
            var occupationDetails = await _dbContextClass.Occupation
                .FromSqlRaw("EXEC spOccupationDetails @occupationid, @position, @wage", param)
                .ToListAsync();

            return occupationDetails;
        }
    }
}