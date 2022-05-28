using OneHackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Infrastructure.DummyData
{
    public class DummyUserItems
    {
        public static List<UserItem> GetUserItems()
        {
            List<UserItem> usetItems = new List<UserItem>();

            var usetItem1 = new UserItem()
            {
                Id = 3,
                Name = "Raports",
                Credentials = "User",
                Email = "dev@rocksoft.com",
                Description = "Whatever it takes",
                Date = DateTimeOffset.Now,
                UserId = 3,
                TimeLineId = 4,
            };
            var usetItem2 = new UserItem()
            {
                Id = 4,
                Name = "Raports",
                Credentials = "User",
                Email = "dev@rocksoft.com",
                Description = "Whatever it takes",
                Date = DateTimeOffset.Now.AddDays(2),
                UserId = 3,
                TimeLineId = 4,
            };
            var usetItem3 = new UserItem()
            {
                Id = 5,
                Name = "Raports",
                Credentials = "User",
                Email = "dev@rocksoft.com",
                Description = "Whatever it takes",
                Date = DateTimeOffset.Now.AddDays(3),
                UserId = 3,
                TimeLineId = 4,
            };
            var usetItem4 = new UserItem()
            {
                Id = 6,
                Name = "Raports",
                Credentials = "User",
                Email = "dev@pitney.com",
                Description = "Whatever it takes",
                Date = DateTimeOffset.Now.AddDays(5),
                UserId = 4,
                TimeLineId = 5,
            };
            var usetItem5 = new UserItem()
            {
                Id = 7,
                Name = "Raports",
                Credentials = "User",
                Email = "dev@pitney.com",
                Description = "Whatever it takes",
                Date = DateTimeOffset.Now.AddDays(6),
                UserId = 4,
                TimeLineId = 5,
            };


            usetItems.Add(usetItem1);
            usetItems.Add(usetItem2);
            usetItems.Add(usetItem3);
            usetItems.Add(usetItem4);
            usetItems.Add(usetItem5);

            return usetItems;
        }
    }
}

