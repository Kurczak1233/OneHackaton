using OneHackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Infrastructure.DummyData
{
    public class DummyRaports
    {
        public static List<Raport> GetRaports()
        {
            List<Raport> raports = new List<Raport>();

            var raport1 = new Raport()
            {
                Id = 4,
                Created = DateTime.Now,
                Name = "Raport",
                Email = "dev@rocksoft.com",
                Credentials = "Managment",
                Description = "object instance not set to an instance of an object"
            };
            var raport2 = new Raport()
            {
                Id = 5,
                Created = DateTime.Now.AddHours(5),
                Name = "Pitney Bowes",
                Email = "dev@pitney.com",
                Credentials = "Managment",
                Description = "object instance not set to an instance of an object"
            };

            raports.Add(raport1);
            raports.Add(raport2);

            return raports;
        }
    }
}
