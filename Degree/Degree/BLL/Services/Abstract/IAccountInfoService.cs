using Degree.BLL.Dtos;

namespace Degree.BLL.Services.Abstract
{
    public interface IAccountInfoService
    {
        public Task AddAsync(AccountInfoDto entity);
        public Task UpdateAsync(AccountInfoDto entity);
        public Task DeleteAsync(int id);
        public Task<AccountInfoDto> GetByIdAsync(int id);
        public Task<IEnumerable<AccountInfoDto>> GetAllAsync();
    }
}
