using OneHackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Infrastructure.DummyData
{
    public class DummyClient
    {
        public static List<Client> GetClients()
        {
            List<Client> clients = new List<Client>();

            var client1 = new Client()
            {
                Id = 7,
                Name = "Cavatina"
            };
            var client2 = new Client()
            {
                Id = 8,
                Name = "RockSoft"
            };

            clients.Add(client1);
            clients.Add(client2);

            return clients;
        }
    }
}
