using OneHackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Infrastructure.DummyData
{
    public class DumyTeams
    {
        public static List<Team> GetTeams()
        {
            List<Team> timelines = new List<Team>();

            var timeLine1 = new Team()
            {
                Id = 2,
                Name = "Development team"
            };
            var timeLine2 = new Team()
            {
                Id = 3,
                Name = "QA team"
            };


            timelines.Add(timeLine1);
            timelines.Add(timeLine2);

            return timelines;
        }


    }
}
