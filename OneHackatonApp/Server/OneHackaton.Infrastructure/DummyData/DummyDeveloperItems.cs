using OneHackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Infrastructure.DummyData
{
    public class DummyDeveloperItems
    {
        public static List<DeveloperItem> GetDeveloperItems()
        {
            List<DeveloperItem> developerItems = new List<DeveloperItem>();

            var devItem1 = new DeveloperItem()
            {
                Id = 3,
                Name = "DevItem",
                Credentials = "Dev",
                Email = "dev@rocksoft.com",
                Description = "Whatever it takes",
                Date = DateTimeOffset.Now,
                DeveloperId = 4,
                TimeLineId = 4,
            };
            var devItem2 = new DeveloperItem()
            {
                Id = 4,
                Name = "DevItem",
                Credentials = "Dev",
                Email = "dev@rocksoft.com",
                Description = "Whatever it takes",
                Date = DateTimeOffset.Now.AddDays(2),
                DeveloperId = 5,
                TimeLineId = 5,
            };


            developerItems.Add(devItem1);
            developerItems.Add(devItem2);

            return developerItems;
        }
    }
}

