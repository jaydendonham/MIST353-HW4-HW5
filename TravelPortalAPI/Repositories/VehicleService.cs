using TravelPortalAPI.Data;
using TravelPortalAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

//Ryan Sladic
namespace TravelPortalAPI.Repositories
{
    public class VehicleService : IVehicleService
    {
        private readonly DbContextClass _dbContextClass;

        public VehicleService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<List<Entities.Vehicle>> GetVehicleDetails(int VIN, string VMake, string VModel, string VYear)
        {
            var param = new SqlParameter("@VehicleID", VIN);

            var vehicleDetails = await _dbContextClass.Vehicle
                .FromSqlRaw("EXEC spVehicleDetails @vehicleid, @VMake, @VModel, @VYear", param)
                .ToListAsync();

            return vehicleDetails;
        }
    }
}
