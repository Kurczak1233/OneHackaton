using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Domain.DTOs
{
    public class TimelineVM
    {
        public DateTime Date { get; set; }
        public IEnumerable<DeveloperItemDto> DeveloperItems { get; set; }
        public IEnumerable<UserItemDTO> UserItems { get; set; }
    }
}
