using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Infrastructure.Repositories
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        public virtual T Add(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual T AddRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public virtual T Get(int id)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual T GetSingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public virtual T Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual T RemoveRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public virtual void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public virtual T Update(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual T UpdateRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }
    }
}
