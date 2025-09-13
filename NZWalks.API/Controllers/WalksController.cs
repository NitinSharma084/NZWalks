using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Repositories;
using NZWalks.API.Models.DTOs;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {
        private readonly IWalksRepository walksRepository;
        private readonly IMapper mapper;
        public WalksController(IWalksRepository walksRepository, IMapper mapper) {
            this.walksRepository = walksRepository;
            this.mapper = mapper;
        }

        public async Task<IActionResult> GetAll(WalkDto walkDto)
        {
            var walksDomain = await walksRepository.GetAllAsync();
            var walksDto = mapper.Map<List<WalkDto>>(walksDomain);
            return Ok(walksDto);    
        }
    }
}
