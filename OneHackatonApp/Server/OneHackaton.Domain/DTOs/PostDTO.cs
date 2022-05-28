using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Domain.DTOs
{
    public class PostDTO
    {
        public string Credentials { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}
