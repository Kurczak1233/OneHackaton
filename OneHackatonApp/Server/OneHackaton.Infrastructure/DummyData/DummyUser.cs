using OneHackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Infrastructure.DummyData
{
    public class DummyUser
    {
        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();

            var user1 = new User()
            {
                Id = 3,
                Email = "User@User.com",
                NickName = "Userek"
            };
            var user2 = new User()
            {
                Id = 4,
                Email = "Marcin@User.com",
                NickName = "Marcin"
            };

            users.Add(user1);
            users.Add(user2);

            return users;
        }
    }
}
