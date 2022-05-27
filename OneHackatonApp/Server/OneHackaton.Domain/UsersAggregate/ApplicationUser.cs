using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Domain.UsersAggregate
{
    public record ApplicationUser
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string NickName { get; set; }        
    }
}
