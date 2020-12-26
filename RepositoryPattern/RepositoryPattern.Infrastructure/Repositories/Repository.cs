using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Infrastructure.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected SchoolContext schoolContext { get; set; }
        public Repository(SchoolContext schoolContext)
        {
            this.schoolContext = schoolContext;
        }
        public virtual T Add(T entity)
        {
            return schoolContext.Add(entity).Entity;
        }

        public virtual void AddRange(IEnumerable<T> entities)
        {
             schoolContext.AddRange(entities);
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return schoolContext.Find<IEnumerable<T>>(predicate).ToList();
        }

        public virtual T Get(int id)
        {
            return schoolContext.Find<T>(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return schoolContext.Set<T>().ToList();
        }

        public virtual T GetSingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            return schoolContext.Set<T>()
                .AsQueryable()
                .Where(predicate)
                .SingleOrDefault();
        }

        public virtual T Remove(T entity)
        {
            return schoolContext.Remove(entity).Entity;
        }

        public virtual void RemoveRange(IEnumerable<T> entities)
        {
           schoolContext.RemoveRange(entities);
        }

        public virtual void SaveChanges()
        {
            schoolContext.SaveChanges();
        }

        public virtual T Update(T entity)
        {
            return schoolContext.Update(entity).Entity;
        }

        public virtual void UpdateRange(IEnumerable<T> entities)
        {
            schoolContext.UpdateRange(entities);
        }
    }
}
