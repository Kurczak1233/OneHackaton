using Microsoft.AspNetCore.Mvc;
using OneHackaton.Domain.DTOs;

namespace OneHackaton.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimeLineController : Controller
    {
        [HttpGet(Name = "GetTestItem")]
        public IEnumerable<TimelineVM> Get()
        {
            return new List<TimelineVM>() { new TimelineVM()
            {
                Date=DateTime.Today,
                DeveloperItems=new List<DeveloperItemDto>() {
                    new DeveloperItemDto(){Name="bug request" }
                },
                UserItems = new List<UserItemDTO>() {
                    new UserItemDTO(){Name="bug request" }
                }
            }};
        }
    }
}
