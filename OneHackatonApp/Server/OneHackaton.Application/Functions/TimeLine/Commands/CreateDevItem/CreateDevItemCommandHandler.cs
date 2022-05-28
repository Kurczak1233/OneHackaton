using AutoMapper;
using MediatR;
using OneHackaton.Domain.Contracts;
using OneHackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Application.Functions.TimeLine.Commands.CreateDevItem
{
    public class CreateDevItemCommandHandler : IRequestHandler<CreateDevItemCommand>
    {
        private readonly IDevRepository _devRepository;
        private readonly IMapper _mapper;

        public CreateDevItemCommandHandler(IMapper mapper,IDevRepository devRepository)
        {
            _devRepository = devRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(CreateDevItemCommand request, CancellationToken cancellationToken)
        {
            var devItem = _mapper.Map<DeveloperItem>(request);
            await _devRepository.AddAsync(devItem);

            return Unit.Value;
        }
    }
}
