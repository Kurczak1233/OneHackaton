using MediatR;
using Microsoft.AspNetCore.Mvc;
using OneHackaton.Application.Functions.TimeLine.Commands.CreateDevItem;
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
        public async Task<ActionResult> DevPost([FromBody] PostDTO postDTO)
        {
            await _mediator.Send(new CreateDevItemCommand(postDTO.Credentials, postDTO.Description, postDTO.Email, postDTO.Date));

            return Ok();
        }
    }
}
