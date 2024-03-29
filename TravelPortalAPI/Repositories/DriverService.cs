using TravelPortalAPI.Data;
using TravelPortalAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

//Josh Keller
namespace TravelPortalAPI.Repositories
{
    public class Driver : IDriver
    {
	private readonly DbContextClass _dbContextClass;

	public DriverService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

	//public async Task<List<Driver>> DriverRetrieveDetails(int did)
	//{
	//var param = new SqlParameter("@did", did);

	//In-Class Example had a "Find Hotel" function like this
	//Putting the building blocks here for future implementation of find driver
	//It'd be kinda useless to add drivers to not be able to find their details
	//But it's not necessary at this stage in development
	//}

        public async Task<int> AddDriver(Driver driver)
	{
	var dPosition = new SqlParameter("@DPosition", driver.DPosition);
	var d_First = new SqlParameter("@D_First", driver.D_First);
	var d_Last = new SqlParameter("@D_Last", driver.D_Last);
	var d_Hometown = new SqlParameter("@D_Hometown", driver.D_Hometown);
	var d_LNum = new SqlParameter("@D_LNum", driver.D_LNum);
	var driverDetails = await Task.Run(() => _dbContextClass.Database.ExecuteSqlRaw("exec addDriver @DPosition, @D_First, @D_Last, @D_Hometown, @D_LNum", dPosition, d_First, d_Last, d_Hometown, d_LNum)); 
	return driverDetails;
	}
    }
}
