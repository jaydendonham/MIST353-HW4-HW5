using TravelPortalAPI.Data;
using TravelPortalAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace TravelPortalAPI.Repositories
{
    public class PartRepository : IPartRepository
    {
        private readonly DbContextClass _dbContext;

        public PartRepository(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Part> GetPartByNumber(int pNum)
        {
            return await _dbContext.Parts.FindAsync(pNum);
        }

        public async Task<List<Part>> GetAllParts()
        {
            return await _dbContext.Parts.ToListAsync();
        }

        public async Task AddPart(Part part)
        {
            _dbContext.Parts.Add(part);
            await _dbContext.SaveChangesAsync();
        }
     public async Task DeletePart(int pNum)
        {
            var part = await _dbContext.Parts.FindAsync(pNum);

            if (part != null) //Will not allow delete of part not in the system
            {
                _dbContext.Parts.Remove(part);
                await _dbContext.SaveChangesAsync();
            }
    }
    public interface IPartRepository
    {
        Task<Part> GetPartByNumber(int pNum);
        
        Task<List<Part>> GetAllParts();
        
        Task AddPart(Part part);
        
        Task DeletePart(Part part); 
    }
}

