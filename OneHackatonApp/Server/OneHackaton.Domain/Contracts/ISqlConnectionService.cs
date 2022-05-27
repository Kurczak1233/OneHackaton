using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Domain.Contracts
{
    public interface ISqlConnectionService
    {
        Task<SqlConnection> GetAsync();
    }
}
