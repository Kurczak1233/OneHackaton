using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Infrastructure.Middlewares.Commands
{
    public class CreateNewUserCommandHandler : IRequestHandler<CreateNewUserCommand>
    {
        public CreateNewUserCommandHandler()
        {

        }
        public Task<Unit> Handle(CreateNewUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
