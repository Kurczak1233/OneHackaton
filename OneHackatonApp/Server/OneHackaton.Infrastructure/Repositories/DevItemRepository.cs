using OneHackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Infrastructure.Repositories
{
    public class DevItemRepository : BaseRepository<DeveloperItem>, IDevRepository
    {
        public DevItemRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
