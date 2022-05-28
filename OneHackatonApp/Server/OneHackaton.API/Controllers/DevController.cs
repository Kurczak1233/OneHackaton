using MediatR;
using Microsoft.AspNetCore.Mvc;
using OneHackaton.Domain.DTOs;

namespace OneHackaton.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DevController : Controller
    {
        private readonly IMediator _mediator;

        public DevController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public IActionResult DevPost([FromBody] PostDTO postDTO)
        {
            return Ok();
        }
    }
}
