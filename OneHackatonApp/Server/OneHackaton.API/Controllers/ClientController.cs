using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OneHackaton.Application.Functions.TimeLine.Commands.CreateUserItem;
using OneHackaton.Domain.DTOs;

namespace OneHackaton.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ClientController(IMediator mediator,IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> UserPost([FromBody] PostDTO postDTO)
        {
            await _mediator.Send(new CreateUserItemCommand(postDTO.Credentials, postDTO.Description, postDTO.Email, postDTO.Date));
            return Ok();
        }
    }
}
