using Microsoft.AspNetCore.Mvc;
using OneHackaton.Domain.DTOs;

namespace OneHackaton.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DevController : Controller
    {
        [HttpPost]
        public IActionResult DevPost([FromBody] PostDTO postDTO)
        {
            return Ok();
        }
    }
}
