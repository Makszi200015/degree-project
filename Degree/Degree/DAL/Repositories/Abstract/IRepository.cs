using Degree.DAL.Domain.Abstract;

namespace Degree.DAL.Repositories.Abstract;

public interface IRepository<TEntity, TKey> : IDisposable where TEntity : SimpleDomainModel<TKey>
{
    Task Add(TEntity obj);
    Task<TEntity?> GetByIdAsync(TKey id);
    Task<IEnumerable<TEntity>> GetAllAsync();
    void Update(TEntity obj);
    void Remove(TKey id);
}