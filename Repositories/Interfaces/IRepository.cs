using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();

        Task<IEnumerable<T>> Find(Func<T, bool> predicate);

        Task<T> GetById(int id);

        Task Create(T entity);

        Task Update(T entity);

        Task Delete(T entity);

        Task<int> Count(Func<T, bool> predicate);
    }
}
