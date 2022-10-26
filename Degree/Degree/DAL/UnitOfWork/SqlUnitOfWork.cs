using Degree.DAL.Context;
using Degree.DAL.Domain.Abstract;
using Degree.DAL.Repositories.Abstract;
using Degree.DAL.UnitOfWork.Abstract;
using TaskList.Domain.Repositories;

namespace TaskList.Domain.UnitOfWorks
{
    public class SqlUnitOfWork<TEntity, TKey> : IDisposable, IUnitOfWork<TEntity, TKey> where TEntity : SimpleDomainModel<TKey>
    {
        private readonly MyDbContext _context;
        
        public IRepository<TEntity, TKey> Repository { get; set; }

        public SqlUnitOfWork(MyDbContext context, SqlRepository<TEntity, TKey> repository)
        {
            _context = context;
            Repository = repository;
        }
        
        public Task<bool> SaveChangesAsync()
        {
            var res = _context.SaveChanges();
            return Task.FromResult(res > 0);
        }
        
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
