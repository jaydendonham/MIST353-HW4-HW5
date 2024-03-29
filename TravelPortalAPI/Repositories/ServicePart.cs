using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelPortalAPI.Data;
using TravelPortalAPI.Entities;

//Ryan Sladic
namespace TravelPortalAPI.Repositories
{
    public class PartRepository : IPartRepository
    {
        private readonly DbContext _dbContext;

        public PartRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Part> GetPartByNumber(int pNum)
        {
            return await _dbContext.Set<Part>().FirstOrDefaultAsync(p => p.PNum == pNum);
        }

        public async Task<List<Part>> GetAllParts()
        {
            return await _dbContext.Set<Part>().ToListAsync();
        }

        public async Task AddPart(Part part)
        {
            _dbContext.Set<Part>().Add(part);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeletePart(int pNum)
        {
            var partToDelete = await _dbContext.Set<Part>().FindAsync(pNum);
            if (partToDelete != null)
            {
                _dbContext.Set<Part>().Remove(partToDelete);
                await _dbContext.SaveChangesAsync();
            }
        }
    }

    public interface IPartRepository
    {
        Task<Part> GetPartByNumber(int pNum);
        Task<List<Part>> GetAllParts();
        Task AddPart(Part part);
        Task DeletePart(int pNum);
    }
}
