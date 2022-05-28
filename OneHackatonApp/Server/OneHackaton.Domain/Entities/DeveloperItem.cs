using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Domain.Entities
{
    public class DeveloperItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Credentials { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public DateTimeOffset Date { get; set; }
        public int DeveloperId { get; set; }
        public virtual Developer Developer{ get; set; }
        public int TimeLineId { get; set; }
        public virtual Timeline Timeline { get; set; }
    }
}
