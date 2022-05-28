using AutoMapper;
using MediatR;
using OneHackaton.Domain.Contracts;
using OneHackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Application.Functions.TimeLine.Commands.CreateUserItem
{
    public class CreateUserItemCommandHandler
    {
        private readonly IMapper _mapper;
        private readonly IUserItemRepository _userItemRepository;

        public CreateUserItemCommandHandler(IMapper mapper, IUserItemRepository userItemRepository)
        {
            _mapper = mapper;
            _userItemRepository = userItemRepository;
        }
        public async Task<Unit> Handle(CreateUserItemCommand request, CancellationToken cancellationToken)
        {
            var raport = _mapper.Map<UserItem>(request);
            await _userItemRepository.AddAsync(raport);

            return Unit.Value;
        }
    }
}
