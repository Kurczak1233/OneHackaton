using MediatR;
using OneHackaton.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Infrastructure.Middlewares.Commands
{
    public class CreateNewUserCommandHandler : IRequestHandler<CreateNewUserCommand>
    {
        private readonly ISqlConnectionService _sqlConnectionService;

        public CreateNewUserCommandHandler(ISqlConnectionService sqlConnectionService)
        {
            _sqlConnectionService = sqlConnectionService;
        }
        public async Task<Unit> Handle(CreateNewUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
