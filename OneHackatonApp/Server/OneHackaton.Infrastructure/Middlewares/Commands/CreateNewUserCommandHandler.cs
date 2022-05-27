using AutoMapper;
using MediatR;
using OneHackaton.Domain.Contracts;
using OneHackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Infrastructure.Middlewares.Commands
{
    public class CreateNewUserCommandHandler : IRequestHandler<CreateNewUserCommand>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public CreateNewUserCommandHandler(IMapper mapper,IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(CreateNewUserCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request);
            await _userRepository.AddAsync(user);

            return Unit.Value;
        }
    }
}
