using AutoMapper;
using Degree.BLL.Services.Abstract;
using Degree.DAL.Domain.Abstract;
using Degree.DAL.UnitOfWork.Abstract;
using Microsoft.EntityFrameworkCore;
using TaskList.Domain.UnitOfWorks;

namespace Degree.BLL.Services
{
    public class Service<TEntity, TKey> : IService<TEntity, TKey> where TEntity : SimpleDomainModel<TKey>
    {
        private readonly IUnitOfWork<TEntity, TKey> _unitOfWork;
        private readonly IMapper _mapper;

        public Service(SqlUnitOfWork<TEntity, TKey> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task AddAsync(TEntity entity)
        {
            var model = _mapper.Map<TEntity>(entity);
            _ = _unitOfWork.Repository.Add(model);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(TKey id)
        {
            _unitOfWork.Repository.Remove(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var models = await _unitOfWork.Repository.GetAll().ToListAsync();
            return _mapper.Map<List<TEntity>>(models);
        }

        public async Task<TEntity> GetByIdAsync(TKey id)
        {
            var task = await _unitOfWork.Repository.GetByIdAsync(id);
            return _mapper.Map<TEntity>(task);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            var task = _mapper.Map<TEntity>(entity);
            _unitOfWork.Repository.Update(task);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
