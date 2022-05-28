﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using OneHackaton.Application.Functions.TimeLine.Commands.CreateRaport;
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
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadTimelineVM>>> GetTestItem()
        {
            var result = await _mediator.Send(new GetAllTimeLinesQuery());
            if(result == null)
                return NoContent();

            return Ok(result);
        }
<<<<<<< HEAD
        [HttpPost("CreateRaport")]
        public async Task<ActionResult> CreateRaport([FromBody] CreateRaportCommand createRaportCommand)
        {
            await _mediator.Send(createRaportCommand);

            return Ok();
        }
=======
        //[HttpPost]
        //public async Task<ActionResult> CreateRaport()
        //{

        //}
>>>>>>> b27a57b87cae0018a18eb55ede93fc2dd2683e39

        //[HttpPost("AddFeedback")]
        //public int AddFeedback([FromBody] string eredentials, string email, string description)
        //{

        //}
<<<<<<< HEAD

=======
>>>>>>> b27a57b87cae0018a18eb55ede93fc2dd2683e39
    }
}
