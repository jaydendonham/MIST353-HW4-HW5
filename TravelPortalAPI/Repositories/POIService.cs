using TravelPortalAPI.Data;
using TravelPortalAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

//Josh Keller
namespace TravelPortalAPI.Repositories
{
    public class POIService : IPOIService
    {
	private readonly DbContextClass _dbContextClass;
	public POIService(DbContextClass dbContextClass)
	{
		_dbContextClass = dbContextClass;
	}
	
	public async Task<List<POI>> POIGetDetails(string poi_state)
	{
	var param = new SqlParameter("@poi_state", poi_state);
	var poiDetails = await Task.Run(() => _dbContextClass.POI.FromSqlRaw("exec findPOIByState @poi_state", param).ToListAsync());
	return poiDetails;
	}

	//Eventually we can put an add POI method here
    }
}
