using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Application.Functions.TimeLine.Commands.CreateRaport
{
    public class CreateRaportCommandHandler : IRequestHandler<CreateRaportCommand>
    {
        public Task<Unit> Handle(CreateRaportCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
