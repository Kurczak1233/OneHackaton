using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Domain.Entities
{
    public class Raport
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Credentials { get; set; }
        public string Description { get; set; }
    }
}
