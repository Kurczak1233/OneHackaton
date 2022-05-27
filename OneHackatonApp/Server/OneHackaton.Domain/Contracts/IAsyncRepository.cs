using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Domain.Contracts
{
    public interface IAsyncRepository<T>
    {
        public Task<T> AddAsync(T entity);

        public Task DeleteAsync(T entity);

        public Task<IReadOnlyList<T>> GetAllAsync();

        public Task<T> GetByIdAsync(int id);

        public Task UpdateAsync(T entity);
    }
}
