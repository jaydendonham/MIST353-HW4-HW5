using TravelPortalAPI.Repositories;
using TravelPortalAPI.Entities;
using Microsoft.AspNetCore.Mvc;

//Ryan Sladic

namespace TravelPortalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PartController : ControllerBase
    {
        private readonly IPartRepository _partRepository;

        public PartController(IPartRepository partRepository)
        {
            _partRepository = partRepository;
        }
        [HttpGet("{pNum}")]
        public async Task<ActionResult<Part>> GetPart(int pNum)
        {
            var part = await _partRepository.GetPartByNumber(pNum);
            if (part == null)
            {
                return NotFound();
            {
            return part;
        }

        [HttpGet("PartName")] 
        public async Task<ActionResult<IEnumerable<Part>>> GetAllParts()
        {
            var parts = await _partRepository.GetAllParts();
            return Ok(parts);
        }
    }
}