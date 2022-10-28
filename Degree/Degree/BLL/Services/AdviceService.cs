using AutoMapper;
using Degree.BLL.Dtos;
using Degree.BLL.Services.Abstract;
using Degree.DAL.Domain;
using Degree.DAL.UnitOfWork.Abstract;
using Microsoft.EntityFrameworkCore;
using TaskList.Domain.UnitOfWorks;

namespace Degree.BLL.Services
{
    public class AdviceService : IAdviceService
    {
        private readonly IUnitOfWork<Advice, int> _unitOfWork;
        private readonly IMapper _mapper;

        public AdviceService(SqlUnitOfWork<Advice, int> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task AddAsync(AdviceDto entity)
        {
            var model = _mapper.Map<Advice>(entity);
            _ = _unitOfWork.Repository.Add(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            _unitOfWork.Repository.Remove(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<AdviceDto>> GetAllAsync()
        {
            var models = await _unitOfWork.Repository.GetAll().ToListAsync();
            return _mapper.Map<List<AdviceDto>>(models);
        }

        public async Task<AdviceDto> GetByIdAsync(int id)
        {
            var task = await _unitOfWork.Repository.GetByIdAsync(id);
            return _mapper.Map<AdviceDto>(task);
        }

        public async Task UpdateAsync(AdviceDto entity)
        {
            var task = _mapper.Map<Advice>(entity);
            _unitOfWork.Repository.Update(task);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
