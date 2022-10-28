using AutoMapper;
using Degree.BLL.Dtos;
using Degree.BLL.Services.Abstract;
using Degree.DAL.Domain;
using Degree.DAL.UnitOfWork.Abstract;
using Microsoft.EntityFrameworkCore;
using TaskList.Domain.UnitOfWorks;

namespace Degree.BLL.Services
{
    public class SearchHistoryService : ISearchHistoryService
    {
        private readonly IUnitOfWork<SearchHistory, int> _unitOfWork;
        private readonly IMapper _mapper;

        public SearchHistoryService(SqlUnitOfWork<SearchHistory, int> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task AddAsync(SearchHistoryDto entity)
        {
            var model = _mapper.Map<SearchHistory>(entity);
            _ = _unitOfWork.Repository.Add(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            _unitOfWork.Repository.Remove(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<SearchHistoryDto>> GetAllAsync()
        {
            var models = await _unitOfWork.Repository.GetAll().ToListAsync();
            return _mapper.Map<List<SearchHistoryDto>>(models);
        }

        public async Task<SearchHistoryDto> GetByIdAsync(int id)
        {
            var task = await _unitOfWork.Repository.GetByIdAsync(id);
            return _mapper.Map<SearchHistoryDto>(task);
        }

        public async Task UpdateAsync(SearchHistoryDto entity)
        {
            var task = _mapper.Map<SearchHistory>(entity);
            _unitOfWork.Repository.Update(task);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
