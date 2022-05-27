using Dapper;
using OneHackaton.Domain.Contracts;
using OneHackaton.Domain.DbScheme;
using OneHackaton.Domain.Entities;
using OneHackaton.Domain.UsersAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Infrastructure.Middlewares.Queries
{
    public class UsersServiceQueries : IUsersServiceQueries
    {
        private readonly ISqlConnectionService _sqlConnectionService;

        public UsersServiceQueries(ISqlConnectionService sqlConnectionService)
        {
            _sqlConnectionService = sqlConnectionService;
        }

        public async Task<ApplicationUser> GetApplicationUserByEmail(string userEmail)
        {
            var connection = await _sqlConnectionService.GetAsync();

            var user = (await connection.QueryAsync<ApplicationUser>(GetApplicationUserByEmailSql(), new { userEmail = userEmail })).SingleOrDefault();

            return user;
        }
        private string GetApplicationUserByEmailSql() => $@"SELECT {nameof(User.Id)},
                                 {nameof(User.Email)}
                                 FROM {(Dbo.Users)}  
                                 WHERE {nameof(User.Email)} = @userEmail";
    }
}
