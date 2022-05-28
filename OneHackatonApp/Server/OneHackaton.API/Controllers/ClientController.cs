using Microsoft.AspNetCore.Mvc;
using OneHackaton.Domain.DTOs;

namespace OneHackaton.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : Controller
    {
        private readonly IMediator _mediator;

        public TimeLineController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public IActionResult UserPost([FromBody] PostDTO postDTO)
        {
            return Ok();
        }
    }
}
