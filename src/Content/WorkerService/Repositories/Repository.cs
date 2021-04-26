using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService.Repositories
{
    public class Repository<T>: IRepository<T>
                                where T: class
    {
        /// <summary>
        /// Add database context and implement the Repositories
        /// Example: WorkerServiceContext
        /// Use Set<typeparamref name="T"/> from Context to implement the below functions
        /// </summary>
        public Repository()
        {

        }

        public Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity, int Id)
        {
            throw new NotImplementedException();
        }
    }
}
