using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OneHackaton.Application.Functions.TimeLine.Commands.CreateUserItem;
using OneHackaton.Domain.DTOs;

namespace OneHackaton.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
        public async Task<IActionResult> UserPost([FromBody] CreateUserItemCommand createUserItemCommand)
        {
            await _mediator.Send(createUserItemCommand);
            return Ok();
        }
    }
}
