using AutoMapper;
using Degree.BLL.Dtos;
using Degree.BLL.Services.Abstract;
using Degree.DAL.Domain;
using Degree.DAL.UnitOfWork.Abstract;
using Microsoft.EntityFrameworkCore;
using TaskList.Domain.UnitOfWorks;

namespace Degree.BLL.Services
{
    public class AccountInfoService : IAccountInfoService
    {
        private readonly IUnitOfWork<AccountInfo, int> _unitOfWork;
        private readonly IMapper _mapper;

        public AccountInfoService(SqlUnitOfWork<AccountInfo, int> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task AddAsync(AccountInfoDto entity)
        {
            var model = _mapper.Map<AccountInfo>(entity);
            _ = _unitOfWork.Repository.Add(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            _unitOfWork.Repository.Remove(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<AccountInfoDto>> GetAllAsync()
        {
            var models = await _unitOfWork.Repository.GetAll().ToListAsync();
            return _mapper.Map<List<AccountInfoDto>>(models);
        }

        public async Task<AccountInfoDto> GetByIdAsync(int id)
        {
            var task = await _unitOfWork.Repository.GetByIdAsync(id);
            return _mapper.Map<AccountInfoDto>(task);
        }

        public async Task UpdateAsync(AccountInfoDto entity)
        {
            var task = _mapper.Map<AccountInfo>(entity);
            _unitOfWork.Repository.Update(task);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
