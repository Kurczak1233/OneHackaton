using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Domain.Entities
{
    public class UserItem
    {
        public int Id { get; set; }
        public string Credentials { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public DateTimeOffset Date { get; set; } = DateTimeOffset.Now;
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int TimeLineId { get; set; }
        public virtual Timeline Timeline { get; set; }
        
    }
}
