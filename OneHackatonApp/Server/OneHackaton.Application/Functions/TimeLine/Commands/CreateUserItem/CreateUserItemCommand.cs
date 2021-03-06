using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Application.Functions.TimeLine.Commands.CreateUserItem
{
    public class CreateUserItemCommand : IRequest
    {
        public DateTimeOffset Date { get; set; }
        public string Name { get; set; } = "Raport";
        public string Email { get; set; }
        public string Credentials { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; } = 3;
        public int TimeLineId { get; set; }
        public CreateUserItemCommand(string credentials, string description, string email, DateTimeOffset date)
        {
            Email = email;
            Credentials = credentials;  
            Description = description;
            Date = date;
        }
    }
}
