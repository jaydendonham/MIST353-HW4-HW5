using TravelPortalAPI.Data;
using TravelPortalAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace TravelPortalAPI.Repositories
{
    public class VehicleRepository : IVehicleService
    {
private readonly DbContextClass _dbContextClass;
        public VehicleService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<Vehicle>> VehicleGetDetails(int vehicleid)
        public async Task<int> AddVehicle(Vehicle vehicle)
        {
          return await _dbContext.Vehicles.FindAsync(vehicleId);
          } 
           public async Task<int> AddVehicle(Vehicle vehicle)
        {
           
            var vehicleID = new SqlParameter("@VehicleID", vehicle.ID);
            var vehicleMake = new SqlParameter("@VehicleAddress", vehicle.Make);
            var vehicleModel = new SqlParameter("@VehicleCity", vehicle.Model);
            var vehicleYear = new SqlParameter("@VehicleState", vehicle.Year);
            } 
 await _dbContext.Vehicles.AddAsync(vehicle);
            await _dbContext.SaveChangesAsync();
            return vehicle.Id; 
            }
        }



