using MediatR;
using OneHackaton.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Application.Functions.TimeLine.Queries.GetAllTimeLines
{
    public class GetAllTimeLinesQuery : IRequest<IEnumerable<ReadTimelineVM>>
    {

    }
}
