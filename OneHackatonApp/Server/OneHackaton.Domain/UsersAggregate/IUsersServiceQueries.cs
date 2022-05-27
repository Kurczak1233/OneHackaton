using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Domain.UsersAggregate
{
    public interface IUsersServiceQueries
    {
        Task<ApplicationUser> GetApplicationUserByEmail(string userEmail);
    }
}
