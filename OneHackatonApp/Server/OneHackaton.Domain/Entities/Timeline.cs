using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Domain.Entities
{
    public class Timeline
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public virtual IEnumerable<DeveloperItemDto> DeveloperItems { get; set; }
        public virtual IEnumerable<UserItemDTO> UserItems { get; set; }
        public string Credentials { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
    }
}
