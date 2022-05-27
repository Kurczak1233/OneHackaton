using OneHackaton.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Domain.ViewModels
{
    public class ReadTimelineVM

    {
        public DateTime Date { get; set; }
        public IEnumerable<DeveloperItemDto> DeveloperItems { get; set; }
        public IEnumerable<UserItemDTO> UserItems { get; set; }
        public string Credentials { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
    }
}
