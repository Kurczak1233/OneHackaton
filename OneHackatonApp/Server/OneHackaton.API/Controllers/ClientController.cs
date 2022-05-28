using Microsoft.AspNetCore.Mvc;
using OneHackaton.Domain.DTOs;

namespace OneHackaton.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : Controller
    {
        [HttpPost]
        public IActionResult UserPost([FromBody] PostDTO postDTO)
        {
            return Ok();
        }
    }
}
