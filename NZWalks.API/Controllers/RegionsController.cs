using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Controllers
{
    // https://localhost:portnumber/api/
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        // https://localhost:portnumber/api/regions
        [HttpGet]
        public IActionResult GetAll()
        {
            var region = new List<Region>
            {
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Auckland Region",
                    Code = "AWL",
                    RegionImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fstock.adobe.com%2Fsearch%3Fk%3Dauckland&psig=AOvVaw2T30BZZQyGH3o7l6Zdprcv&ust=1757611209875000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCJDigpDazo8DFQAAAAAdAAAAABAE"
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Wellington Region",
                    Code = "WLG",
                    RegionImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.expedia.co.in%2FWellington.dx6127327&psig=AOvVaw016trL87_CJnwPBMlC52uq&ust=1757611277565000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIClw7Dazo8DFQAAAAAdAAAAABAE"
                }
            };

            return Ok(region);
        }
    }
}
