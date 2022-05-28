using AutoMapper;
using MediatR;
using OneHackaton.Domain.Contracts;
using OneHackaton.Domain.Entities;
using OneHackaton.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Application.Functions.TimeLine.Commands.CreateUserItem
{
    public class CreateUserItemCommandHandler : IRequestHandler<CreateUserItemCommand>
    {
        private readonly IMapper _mapper;
        private readonly IUserItemRepository _userItemRepository;
        private readonly ApplicationDbContext  _context;

        public CreateUserItemCommandHandler(IMapper mapper, IUserItemRepository userItemRepository,ApplicationDbContext context)
        {
            _mapper = mapper;
            _userItemRepository = userItemRepository;
            _context = context;
        }
        public async Task<Unit> Handle(CreateUserItemCommand request, CancellationToken cancellationToken)
        {
            //Wszystkie timeliny, datimeoffset rówy datemeNow jeżeli tak to przypisz
            var query = _context.TimeLines.FirstOrDefault(x => x.Date == DateTimeOffset.Now).Id;
            if (query != null) request.TimeLineId = query;
            else
            {
                Timeline timeline = new() { Date = DateTimeOffset.Now };
                _context.TimeLines.Add(timeline);
                query = timeline.Id;
                _context.SaveChanges();
            }
            var raport = _mapper.Map<UserItem>(request);
            await _userItemRepository.AddAsync(raport);

            return Unit.Value;
        }
    }
}
