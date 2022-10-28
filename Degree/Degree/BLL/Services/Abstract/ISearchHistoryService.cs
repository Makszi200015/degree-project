using Degree.BLL.Dtos;

namespace Degree.BLL.Services.Abstract
{
    public interface ISearchHistoryService
    {
        public Task AddAsync(SearchHistoryDto entity);
        public Task UpdateAsync(SearchHistoryDto entity);
        public Task DeleteAsync(int id);
        public Task<SearchHistoryDto> GetByIdAsync(int id);
        public Task<IEnumerable<SearchHistoryDto>> GetAllAsync();
    }
}
