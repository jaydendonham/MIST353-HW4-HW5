using TravelPortalAPI.Data;
using TravelPortalAPI.Entities;
using Microsoft.EntityFrameworkCore;

//Ryan Sladic
// Search for vehicle parts based on part number, get all parts from system, add parts to part list, remove parts from part lists.

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
        
        public async Task DeletePart(Part part)
        {
            var existingPart = await _dbContext.Parts.FindAsync(part.PNum);

            if (existingPart != null)
            {
                _dbContext.Parts.Remove(existingPart);
                await _dbContext.SaveChangesAsync();
            }
           else
    {
       
        Console.WriteLine($"{part.PNum} Is not in the part catalog.");
        }
    
    public interface IPartRepository
    {
        Task<Part> GetPartByNumber(int pNum);
        
        Task<List<Part>> GetAllParts();
        
        Task AddPart(Part part);
        
        Task DeletePart(Part part); 
    }
}
