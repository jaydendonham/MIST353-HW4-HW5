using TravelPortalAPI.Data;
using TravelPortalAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

//Josh Keller
namespace TravelPortalAPI.Repositories
{
    public class POI : IPOI
    {
	private readonly DbContextClass _dbContextClass;
	public POIService(DbContextClass dbContextClass)
	{
		_dbContextClass = dbContextClass;
	}
	
	public async Task<List<Hotel>> POIGetDetails(string poi_state)
	{
	var param = new SqlParameter("@poi_state", poi_state);
	var poiDetails //Finish later
    }
}
