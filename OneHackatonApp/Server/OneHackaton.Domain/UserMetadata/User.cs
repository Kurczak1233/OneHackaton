using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Domain.UserMetadata
{
    public class User : IUser
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public User(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public int Id
        {
            get
            {
                var userMetaDataClaim =
                    _httpContextAccessor.HttpContext?.User?.Claims?.FirstOrDefault(c => c.Type == IUserMetadata.UserId);
                int.TryParse(userMetaDataClaim?.Value, out var personId);
                return personId;
            }
            set { }
        }
        public string Email
        {
            get
            {
                var userEmail =
                    _httpContextAccessor.HttpContext?.User?.Claims?.FirstOrDefault(c => c.Type == IUserMetadata.Email);

                return userEmail?.Value!;
            }
            set { }
        }
        public string NickName {
            get
            {
                var userLastName =
                    _httpContextAccessor.HttpContext?.User?.Claims?.FirstOrDefault(c => c.Type == IUserMetadata.NickName);

                return userLastName?.Value!;
            }
            set { }
        }
    }
}
