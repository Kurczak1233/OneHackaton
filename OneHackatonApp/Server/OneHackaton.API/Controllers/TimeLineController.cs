using Microsoft.AspNetCore.Mvc;
using OneHackaton.Domain.DTOs;
using OneHackaton.Domain.ViewModels;

namespace OneHackaton.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimeLineController : Controller
    {
        [HttpGet("GetTestItem")]
        public IEnumerable<ReadTimelineVM> GetTestItem()
        {
            return new List<ReadTimelineVM>() { new ReadTimelineVM()
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
