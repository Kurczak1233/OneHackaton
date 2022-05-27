using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Infrastructure.Middlewares.Commands
{
    public class CreateNewUserCommand : IRequest
    {
        public string Email { get; set; }
        public string Nickname { get; set; }

        public CreateNewUserCommand(string email, string nickname)
        {
            Email = email;
            Nickname = nickname;
        }
    }
}
