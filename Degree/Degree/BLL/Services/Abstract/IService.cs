using Degree.DAL.Domain.Abstract;

namespace Degree.BLL.Services.Abstract
{
    public interface IService<TEntity, TKey> where TEntity : SimpleDomainModel<TKey>
    {
        public Task AddAsync(TEntity entity);
        public Task UpdateAsync(TEntity entity);
        public Task DeleteAsync(TKey id);
        public Task<TEntity> GetByIdAsync(TKey id);
        public Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
