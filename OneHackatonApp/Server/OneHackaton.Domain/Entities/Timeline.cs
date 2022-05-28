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
        public DateTimeOffset Date { get; set; }
        public virtual IEnumerable<DeveloperItem> DeveloperItems { get; set; }
        public virtual IEnumerable<UserItem> UserItems { get; set; }
    }
}
