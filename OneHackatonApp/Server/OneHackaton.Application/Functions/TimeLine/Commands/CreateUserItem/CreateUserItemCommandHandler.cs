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

namespace OneHackaton.Application.Functions.TimeLine.Commands.CreateUserItem
{
    public class CreateUserItemCommandHandler : IRequestHandler<CreateUserItemCommand>
    {
        private readonly IMapper _mapper;
        private readonly IUserItemRepository _userItemRepository;
        private readonly ISqlConnectionService _connection;

        public CreateUserItemCommandHandler(IMapper mapper, IUserItemRepository userItemRepository, ISqlConnectionService connection)
        {
            _mapper = mapper;
            _userItemRepository = userItemRepository;
            _connection = connection;
        }
        public async Task<Unit> Handle(CreateUserItemCommand request, CancellationToken cancellationToken)
        {
            var connection = await _connection.GetAsync();
            var sql = $@"SELECT * FROM TimeLines";

            var listOfTimeLinesEntities = await connection.QueryAsync<Timeline>(sql);
            var query = listOfTimeLinesEntities.FirstOrDefault(x => x.Date.DayOfYear == request.Date.DayOfYear);
            if (query != null) request.TimeLineId = query.Id;
            else
            {
                var sql2 = $@"INSERT INTO TimeLines (Date) VALUES (@Date)";
                var item = await connection.ExecuteAsync(sql2, new { Date = request.Date });
                request.TimeLineId = item;
            }
            var raport = _mapper.Map<UserItem>(request);
            await _userItemRepository.AddAsync(raport);

            return Unit.Value;
        }
    }
}
