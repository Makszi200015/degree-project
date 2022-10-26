using Degree.DAL.Context;
using Degree.DAL.Domain.Abstract;
using Degree.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace TaskList.Domain.Repositories
{
    public class SqlRepository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : SimpleDomainModel<TKey>
    {
        protected readonly MyDbContext _context;
        protected readonly DbSet<TEntity> DbSet;

        public SqlRepository(MyDbContext context)
        {
            _context = context;
            DbSet = _context.Set<TEntity>();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public virtual Task Add(TEntity model)
        {
            DbSet.Add(model);
            return Task.CompletedTask;
        }

        public virtual async Task<TEntity?> GetByIdAsync(TKey id) => await DbSet.FindAsync(id);

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await DbSet.ToListAsync();
        }

        public virtual void Update(TEntity model)
        {
            DbSet.Update(model);
        }

        public virtual void Remove(TKey id)
        {
            DbSet.Remove(DbSet.Find(id));
        }
    }
}
