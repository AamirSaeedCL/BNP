using AR.LinesManagementSystem.Context;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AR.LinesManagementSystem.Repositories
{
    public interface IRepository<T> where T : class
    {
        ArDBContext DbContext { get; }
        Task AddAsync(T entity);
        void AddOrUpdate(T entity);
        Task DeleteAsync(T entity);
        //int Delete(Expression<Func<T, bool>> predicate);
        //void DeleteAll();
        void Dispose();
        Task<List<T>> Find(Expression<Func<T, bool>> predicate);
        Task<T> GetByIdAsync(int? id);
        Task<int> Save();
        Task<T> UpdateAsync(T entity);
    }
}