using DataDomain.Data;
using SchoolSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public ApplicationDbContext context;

        public Repository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<int> Count(Func<T, bool> predicate)
        {
            return context.Set<T>().Count(predicate);
        }

        public async Task Create(T entity)
        {
            context.Set<T>().Add(entity);
            await SaveChanges();
        }

        public async Task Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            await SaveChanges();
        }

        public async Task<IEnumerable<T>> Find(Func<T, bool> predicate)
        {
            return context.Set<T>().Where(predicate);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public async Task<T> GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public async Task Update(T entity)
        {
            T existing = context.Set<T>().Find(entity);
        }

        private async Task SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
