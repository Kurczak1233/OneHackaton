using MediatR;
using Microsoft.AspNetCore.Mvc;
using OneHackaton.Application.Functions.TimeLine.Commands.CreateRaport;
using OneHackaton.Application.Functions.TimeLine.Queries.GetAllTimeLines;
using OneHackaton.Domain.DTOs;
using OneHackaton.Domain.ViewModels;

namespace OneHackaton.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TimeLineController : Controller
    {
        private readonly IMediator _mediator;

        public TimeLineController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadTimelineVM>>> GetTestItem()
        {
            var result = await _mediator.Send(new GetAllTimeLinesQuery());
            if(result == null)
                return NoContent();

            return Ok(result);
        }

        [HttpPost("CreateRaport")]
        public async Task<ActionResult> CreateRaport([FromBody] CreateRaportCommand createRaportCommand)
        {
            await _mediator.Send(createRaportCommand);

            return Ok();
        }
    }
}
