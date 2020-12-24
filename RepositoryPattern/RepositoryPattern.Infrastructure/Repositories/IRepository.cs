﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Infrastructure.Repositories
{
    public interface IRepository<T> 
    {
        T Add(T entity);
        T AddRange(IEnumerable<T> entities);
        T Update(T entity);
        T UpdateRange(IEnumerable<T> entities);
        T Remove(T entity);
        T RemoveRange(IEnumerable<T> entities); 
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        T GetSingleOrDefault(Expression<Func<T, bool>> predicate);
        void SaveChanges();
    }
}
