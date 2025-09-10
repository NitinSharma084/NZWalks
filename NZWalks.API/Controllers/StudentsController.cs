using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    // Get : https://localhost:portnunber/api/
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // Get : https://localhost:portnunber/api/students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok();
        }
    }
}
