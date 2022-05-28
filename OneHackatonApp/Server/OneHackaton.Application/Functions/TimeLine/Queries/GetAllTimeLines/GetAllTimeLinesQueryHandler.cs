using Dapper;
using MediatR;
using OneHackaton.Domain.Contracts;
using OneHackaton.Domain.DbScheme;
using OneHackaton.Domain.DTOs;
using OneHackaton.Domain.Entities;
using OneHackaton.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Application.Functions.TimeLine.Queries.GetAllTimeLines
{
    public class GetAllTimeLinesQueryHandler : IRequestHandler<GetAllTimeLinesQuery, IEnumerable<ReadTimelineVM>>
    {
        private readonly ISqlConnectionService _sqlConnectionService;

        public GetAllTimeLinesQueryHandler(ISqlConnectionService sqlConnectionService)
        {
            _sqlConnectionService = sqlConnectionService;
        }
        public async Task<IEnumerable<ReadTimelineVM>> Handle(GetAllTimeLinesQuery request, CancellationToken cancellationToken)
        {
            var connection = await _sqlConnectionService.GetAsync();

            var getTimeLineSql = $@"SELECT {nameof(Timeline.Id)},
                                 {nameof(Timeline.Date)}
                                 FROM {(Dbo.TimeLines)}";

            var foundTimeLine = await connection.QueryAsync<TimeLineDto>(getTimeLineSql);

            var getDeveloperItemSql = $@"SELECT {nameof(DeveloperItem.Id)},
                                 {nameof(DeveloperItem.Credentials)},
                                 {nameof(DeveloperItem.Email)},
                                 {nameof(DeveloperItem.Description)},
                                 {nameof(DeveloperItem.Date)},
                                 {nameof(DeveloperItem.TimeLineId)}
                                 FROM {(Dbo.DeveloperItems)}";

            var foundDeveloperItems = await connection.QueryAsync<DeveloperItemDto>(getDeveloperItemSql);

            var getUserItemSql = $@"SELECT {nameof(UserItem.Id)},
                                 {nameof(UserItem.Credentials)},
                                 {nameof(UserItem.Email)},
                                 {nameof(UserItem.Description)},
                                 {nameof(UserItem.Date)},
                                 {nameof(UserItem.TimeLineId)}
                                 FROM {(Dbo.UserItems)}";

            var foundUserItems = await connection.QueryAsync<UserItemDTO>(getUserItemSql);

            var listOfViewModel = new List<ReadTimelineVM>();

            foreach (var timeline in foundTimeLine)
            {
                var developerItem = foundDeveloperItems?.Where(x => x.TimeLineId == timeline.Id);
                var userItem = foundUserItems?.Where(x => x.TimeLineId == timeline.Id);

                listOfViewModel.Add(new ReadTimelineVM
                {
                    Id = timeline.Id,
                    Date = timeline.Date,
                    DeveloperItems = developerItem,
                    UserItems = userItem,
                });
            }
            return listOfViewModel;
        }
    }
}
