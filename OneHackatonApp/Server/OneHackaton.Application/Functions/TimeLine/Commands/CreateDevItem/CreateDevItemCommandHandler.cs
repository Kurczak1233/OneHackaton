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

namespace OneHackaton.Application.Functions.TimeLine.Commands.CreateDevItem
{
    public class CreateDevItemCommandHandler : IRequestHandler<CreateDevItemCommand>
    {
        private readonly IDevRepository _devRepository;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public CreateDevItemCommandHandler(IMapper mapper,IDevRepository devRepository, ApplicationDbContext context)
        {
            _devRepository = devRepository;
            _mapper = mapper;
            _context = context;
        }
        public async Task<Unit> Handle(CreateDevItemCommand request, CancellationToken cancellationToken)
        {
            var query = _context.TimeLines.FirstOrDefault(x => x.Date == DateTimeOffset.Now).Id;
            if (query != null) request.TimeLineId = query;
            else
            {
                Timeline timeline = new() { Date = DateTimeOffset.Now };
                _context.TimeLines.Add(timeline);
                query = timeline.Id;
                _context.SaveChanges();
            }
            var devItem = _mapper.Map<DeveloperItem>(request);
            await _devRepository.AddAsync(devItem);

            return Unit.Value;
        }
    }
}
