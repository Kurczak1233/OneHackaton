using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Domain.UserMetadata
{
    public interface IUser
    {
        int Id { get; set; }
        string Email { get; set; }
        string NickName { get; set; }
    }
}
