using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Application.Functions.TimeLine.Commands.CreateUserItem
{
    public class CreateUserItemCommand : IRequest
    {
        public DateTime Created { get; set; } = DateTime.Now;
        public string Name { get; set; } = "Raport";
        public string Email { get; set; }
        public string Credentials { get; set; }
        public string Description { get; set; }
    }
}
