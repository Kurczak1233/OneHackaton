using OneHackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Infrastructure.DummyData
{
    public class DummyTimeLines
    {
        public static List<Timeline> GetTimeLines()
        {
            List<Timeline> timelines = new List<Timeline>();

            var timeLine1 = new Timeline()
            {
                Id = 4,
                Date = DateTime.Now
            };
            var timeLine2 = new Timeline()
            {
                Id = 5,
                Date = DateTime.Now
            };


            timelines.Add(timeLine1);
            timelines.Add(timeLine2);

            return timelines;
        }
    }
}
