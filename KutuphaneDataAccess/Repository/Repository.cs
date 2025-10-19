using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneDataAccess.Repository
{
    public class Repository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly KutuphaneDBContext _context;
        private readonly DbSet<TEntity> _dbSet;
        public Repository(KutuphaneDBContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
          await _dbSet.AddAsync(entity);
        }

        public void Create(TEntity entity)
        {
            _dbSet.Add(entity); 
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public void DeleteRange(List<TEntity> entities)
        {
           _dbSet.RemoveRange(entities);
        }

        public IQueryable<TEntity> GetAll()
        {
          return _dbSet.AsNoTracking().AsQueryable();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
           return await _dbSet.FindAsync(id);
        }

        public IQueryable<TEntity> Quaryable()
        {
            return _dbSet.AsQueryable();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity); 
        }
    }
}
