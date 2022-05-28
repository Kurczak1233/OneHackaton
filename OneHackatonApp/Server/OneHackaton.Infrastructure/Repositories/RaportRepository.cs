using OneHackaton.Domain.Contracts;
using OneHackaton.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Infrastructure.Repositories
{
    public class RaportRepository : BaseRepository<Raport>, IRaportRepository
    {
        public RaportRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
