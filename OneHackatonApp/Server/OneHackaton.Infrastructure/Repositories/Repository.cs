using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Infrastructure.Repositories
{
    public abstract class Repository<TEntity>
    {
        private DataContext _dataContext;

        protected Repository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        protected IQueryable<TEntity> Query
        {
            get { return _dataContext.GetTable<TEntity>(); }
        }

        protected void InsertOnCommit(TEntity entity)
        {
            _dataContext.GetTable<TEntity>().InsertOnCommit(entity);
        }

        protected void DeleteOnCommit(TEntity entity)
        {
            _dataContext.GetTable<TEntity>().DeleteOnCommit(entity);
        }
    }
}
