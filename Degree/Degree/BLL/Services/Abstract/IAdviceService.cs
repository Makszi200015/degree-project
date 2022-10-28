using Degree.BLL.Dtos;

namespace Degree.BLL.Services.Abstract
{
    public interface IAdviceService
    {
        public Task AddAsync(AdviceDto entity);
        public Task UpdateAsync(AdviceDto entity);
        public Task DeleteAsync(int id);
        public Task<AdviceDto> GetByIdAsync(int id);
        public Task<IEnumerable<AdviceDto>> GetAllAsync();
    }
}
