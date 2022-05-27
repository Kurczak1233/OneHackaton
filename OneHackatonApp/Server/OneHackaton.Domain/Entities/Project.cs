using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Domain.Entities
{
    public class Project : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Team Team { get; set; }
    }
}
