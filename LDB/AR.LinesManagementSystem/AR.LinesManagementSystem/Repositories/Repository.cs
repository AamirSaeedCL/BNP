using AR.LinesManagementSystem.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AR.LinesManagementSystem.Repositories
{
    public abstract class Repository<T> : IDisposable, IRepository<T> where T : class
    {
        protected readonly ArDBContext _context;
        protected readonly DbSet<T> _dbset;

        public Repository(ArDBContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }
        public ArDBContext DbContext
        {
            get
            {
                return _context;
            }
        }



        //public virtual void Add(T entity)
        //{
        //    this.BeforeAdd(entity);
        //    _dbset.Add(entity);
        //}

        public virtual async Task AddAsync(T entity)
        {
            this.BeforeAdd(entity);
            await _dbset.AddAsync(entity);
            await Save();
        }

        //public virtual void Delete(T entity)
        //{
        //    _dbset.Remove(entity);
        //}

        public virtual async Task DeleteAsync(T entity)
        {
            await Task.Run(() => _dbset.Remove(entity));
            await Save();
        }
        public virtual async Task<T> UpdateAsync(T entity)
        {
            this.BeforeUpdate(entity);

            var entry = _context.Entry(entity);

            if (entry.State == EntityState.Detached)
            {
                _dbset.Attach(entity);
            }
            entry.State = EntityState.Modified;
            await Save();
            return entity;
        }

        public virtual async void AddOrUpdate(T entity)
        {
            var entry = _context.Entry(entity);

            if (entry.State == EntityState.Detached)
            {
                await Task.Run(() => this.AddAsync(entity));
            }
            else
            {
                await Task.Run(() => this.UpdateAsync(entity));
            }
        }
        public virtual async Task<int> Save() => await _context.SaveChangesAsync();

        public virtual async Task<T> GetByIdAsync(int? Id)
        {
            var entity = await _dbset.FindAsync(Id);
            if (entity != null)
            {
                _context.Entry(entity).State = EntityState.Detached;
            }
            return entity;
        }

        //public Task<T> GetById(int? id)
        //{
        //    throw new NotImplementedException();
        //}

        public virtual async Task<List<T>> GetAllAsync()
        {
            return await _dbset.AsNoTracking().ToListAsync();
        }

        public virtual async Task<List<T>> Find(Expression<Func<T, bool>> predicate)
        {
            return await _dbset.AsNoTracking().Where(predicate).ToListAsync();
        }
        protected virtual void BeforeAdd(T entity)
        {
            //var property = entity.GetType().GetProperty("CreatedAt");
            //if (property != null)
            //{
            //    property.SetValue(entity, DateTimeOffset.Now);
            //}

            //property = entity.GetType().GetProperty("UpdatedAt");
            //if (property != null)
            //{
            //    property.SetValue(entity, DateTimeOffset.Now);
            //}
        }

        protected virtual void BeforeUpdate(T entity)
        {
            //var property = entity.GetType().GetProperty("UpdatedAt");
            //if (property != null)
            //{
            //    property.SetValue(entity, DateTimeOffset.Now);
            //}
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}