using OneHackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Domain.Contracts
{
    public interface IDevRepository : IAsyncRepository<DeveloperItem>
    {
    }
}
