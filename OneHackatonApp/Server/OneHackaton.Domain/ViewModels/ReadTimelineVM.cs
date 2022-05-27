using OneHackaton.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Domain.ViewModels
{
<<<<<<< HEAD:OneHackatonApp/Server/OneHackaton.Domain/DTOs/TimelineVM.cs
    public record TimelineVM
=======
    public class ReadTimelineVM
>>>>>>> f01f21be14f963697ac02672ac0c9c737e82c646:OneHackatonApp/Server/OneHackaton.Domain/ViewModels/ReadTimelineVM.cs
    {
        public DateTime Date { get; set; }
        public IEnumerable<DeveloperItemDto> DeveloperItems { get; set; }
        public IEnumerable<UserItemDTO> UserItems { get; set; }
        public string Credentials { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
    }
}
