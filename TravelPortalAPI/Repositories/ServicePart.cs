using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelPortalAPI.Data;
using TravelPortalAPI.Entities;

namespace TravelPortalAPI.Repositories
{
    public class PartRepository : IPartRepository
    {
        private readonly DbContext _dbContextClass;

        public PartRepository(DbContext dbContext)
        {
            _dbContextClass = dbContext;
        }

        public async Task<Part> GetPartByNumber(int pNum)
        {
            return await _dbContextClass.Part.FirstOrDefaultAsync(p => p.PNum == pNum);
        }

        public async Task<List<Part>> GetAllParts()
        {
            return await _dbContextClass.Part.ToListAsync();
        }

        public async Task AddPart(Part part)
        {
            _dbContextClass.Part.Add(part);
            await _dbContextClass.SaveChangesAsync();
        }

        public async Task DeletePart(int pNum)
        {
            var partToDelete = await _dbContextClass.Part.FindAsync(pNum);
            if (partToDelete != null)
            {
                _dbContextClass.Part.Remove(partToDelete);
                await _dbContextClass.SaveChangesAsync();
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
