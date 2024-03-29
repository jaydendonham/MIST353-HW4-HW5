using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TravelPortalAPI.Entities;
using TravelPortalAPI.Repositories;

//Ryan Sladic
namespace TravelPortalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PartsController : ControllerBase
    {
        private readonly IPartRepository _partRepository;

        public PartsController(IPartRepository partRepository)
        {
            _partRepository = partRepository ?? throw new ArgumentNullException(nameof(partRepository));
        }

        [HttpGet("{pNum}")]
        public async Task<ActionResult<Part>> GetPartByNumber(int pNum)
        {
            var part = await _partRepository.GetPartByNumber(pNum);
            if (part == null)
            {
                return NotFound();
            }
            return Ok(part);
        }

        [HttpGet]
        public async Task<ActionResult<List<Part>>> GetAllParts()
        {
            var parts = await _partRepository.GetAllParts();
            return Ok(parts);
        }

        [HttpPost]
        public async Task<ActionResult<Part>> AddPart(Part part)
        {
            await _partRepository.AddPart(part);
            return CreatedAtAction(nameof(GetPartByNumber), new { pNum = part.PNum }, part);
        }

        [HttpDelete("{pNum}")]
        public async Task<IActionResult> DeletePart(int pNum)
        {
            await _partRepository.DeletePart(pNum);
            return NoContent();
        }
    }
}

