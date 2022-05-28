using AutoMapper;
using Dapper;
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
        private readonly ISqlConnectionService _connection;

        public CreateDevItemCommandHandler(IMapper mapper,IDevRepository devRepository, ISqlConnectionService connection)
        {
            _devRepository = devRepository;
            _mapper = mapper;
            _connection = connection;
        }
        public async Task<Unit> Handle(CreateDevItemCommand request, CancellationToken cancellationToken)
        {
            var connection = await _connection.GetAsync();
            var sql = $@"SELECT * FROM TimeLines";

            var listOfTimeLinesEntities = await connection.QueryAsync<Timeline>(sql);
            var query = listOfTimeLinesEntities.FirstOrDefault(x => x.Date.DayOfYear == request.Date.DayOfYear);
            if (query != null) request.TimeLineId = query.Id;
            else {
                var sql2 = $@"INSERT INTO TimeLines (Date) VALUES (@Date)";
                await connection.ExecuteAsync(sql2, new { Date = request.Date });
                var sql3 = $@"SELECT * FROM TimeLines WHERE Date = @Date";
                var foundItem = await connection.QueryAsync<Timeline>(sql3, new { Date = request.Date });
                var item = foundItem.SingleOrDefault();
                request.TimeLineId = item.Id;
            }
            var devItem = _mapper.Map<DeveloperItem>(request);
            await _devRepository.AddAsync(devItem);

            return Unit.Value;
        }
    }
}
