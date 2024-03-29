using TravelPortalAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace TravelPortalAPI.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options) 
        { }
        public DbSet<Driver> Driver {  get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Occupation> Occupation {  get; set; }
        public DbSet<Part> Part { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
	public DbSet<POI> POI { get; set; }
    }
}
