using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Domain.Entities
{
    public class Client : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
