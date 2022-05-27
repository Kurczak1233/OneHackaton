using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Domain.UserMetadata
{
    public interface IUserMetadata
    {
        public static string NickName => "https://OneHackaton.com/nickname";
        public static string UserId=> "https://OneHackaton.com/userId";
        public static string Email=> "https://OneHackaton.com/email";
    }
}
