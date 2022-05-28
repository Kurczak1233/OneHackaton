using MediatR;
using OneHackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Application.Functions.TimeLine.Commands
{
    public class CreateTimeLineCommand : IRequest
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public IEnumerable<DeveloperItem> DeveloperItems { get; set; }
        public IEnumerable<UserItem> UserItems { get; set; }
    }
}
