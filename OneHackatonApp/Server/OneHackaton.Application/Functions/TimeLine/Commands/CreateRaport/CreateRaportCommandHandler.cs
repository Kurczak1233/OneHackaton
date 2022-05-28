using AutoMapper;
using MediatR;
using OneHackaton.Domain.Contracts;
using OneHackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Application.Functions.TimeLine.Commands.CreateRaport
{
    public class CreateRaportCommandHandler : IRequestHandler<CreateRaportCommand>
    {
        private readonly IMapper _mapper;
        private readonly IRaportRepository _raportRepository;

        public CreateRaportCommandHandler(IMapper mapper, IRaportRepository raportRepository)
        {
            _mapper = mapper;
            _raportRepository = raportRepository;
        }
        public async Task<Unit> Handle(CreateRaportCommand request, CancellationToken cancellationToken)
        {
            var raport = _mapper.Map<Raport>(request);
            await _raportRepository.AddAsync(raport);

            return Unit.Value;
        }
    }
}
