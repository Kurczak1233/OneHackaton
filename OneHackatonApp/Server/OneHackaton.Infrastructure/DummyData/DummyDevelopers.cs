using OneHackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Infrastructure.DummyData
{
    public class DummyDevelopers
    {
        public static List<Developer> GetDevelopers()
        {
            List<Developer> developers = new List<Developer>();

            var developer1 = new Developer()
            {
                Id = 3,
                Name = "MichalDev",
                TeamId = 2
            };
            var developer2 = new Developer()
            {
                Id = 4,
                Name = "JakubDev",
                TeamId = 2
            };
            var developer3 = new Developer()
            {
                Id = 5,
                Name = "MikoDev",
                TeamId = 2
            };
            var developer4 = new Developer()
            {
                Id = 6,
                Name = "MaksDev",
                TeamId = 2
            };

            developers.Add(developer1);
            developers.Add(developer2);
            developers.Add(developer3);
            developers.Add(developer4);

            return developers;
        }
    }
}
