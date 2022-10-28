using Degree.DAL.Domain.Abstract;
using Degree.DAL.Repositories.Abstract;

namespace Degree.DAL.UnitOfWork.Abstract;

public interface IUnitOfWork<TEntity, TKey> : IDisposable where TEntity : SimpleDomainModel<TKey>
{
    IRepository<TEntity, TKey> Repository { get; set; }
    Task<bool> SaveChangesAsync();
}