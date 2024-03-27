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
   
	public async Task<List<Driver>> DriverRetrieveDetails(int did)
	{
	var param = new SqlParameter("@did", did);
	
	//Add DriverDetails here at some point
	}

        public async Task<int> AddDriver(Driver driver)
	{
	var DPosition = new SqlParameter("@DPosition", driver.Position);
	var D_First = new SqlParameter("@D_First", driver.First);
	var D_Last = new SqlParameter("@D_Last", driver.Last);
	var D_Hometown = new SqlParameter("@D_Hometown", driver.Hometown);
	var D_LNum = new SqlParameter("@D_LNum", driver.LNum);

	//Add DriverDetails Here At Some Point
    }
}
