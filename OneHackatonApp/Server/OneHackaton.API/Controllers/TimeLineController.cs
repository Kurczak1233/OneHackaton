using MediatR;
using Microsoft.AspNetCore.Mvc;
using OneHackaton.Application.Functions.TimeLine.Queries.GetAllTimeLines;
using OneHackaton.Domain.DTOs;
using OneHackaton.Domain.ViewModels;

namespace OneHackaton.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimeLineController : Controller
    {
        private readonly IMediator _mediator;

        public TimeLineController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("GetTestItem")]
        public async Task<ActionResult<IEnumerable<ReadTimelineVM>>> GetTestItem()
        {
            var result = await _mediator.Send(new GetAllTimeLinesQuery());
            if(result == null)
                return NoContent();

            return Ok(result);
        }
        //[HttpPost("AddFeedback")]
        //public int AddFeedback([FromBody] string eredentials, string email, string description)
        //{

        //}
    }
}
