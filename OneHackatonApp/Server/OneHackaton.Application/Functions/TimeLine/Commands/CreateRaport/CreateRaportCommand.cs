using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Application.Functions.TimeLine.Commands.CreateRaport
{
    public class CreateRaportCommand : IRequest
    {
        public int Id { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public string Name { get; set; }
        public string Email { get; set; }
        public string Credentials { get; set; }
        public string Descritpion { get; set; }
    }
}
