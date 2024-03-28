using TravelPortalAPI.Repositories;
using TravelPortalAPI.Entities;
using Microsoft.AspNetCore.Mvc;

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
