using FRS.Core.Domain.Entities;
using FRS.Core.Domain.Interfaces;

namespace FRS.Core.Application.Services
{
    public class LpmasterService : ILpmasterService
    {
        private readonly ILpmasterRepository _repository;

        public LpmasterService(ILpmasterRepository repository)
        {
            _repository = repository;
        }

        public async Task AddAsync(Lpmaster subject) => await _repository.AddAsync(subject);
        public async Task DeleteAsync(Lpmaster subject) => await _repository.DeleteAsync(subject);
        public async Task<List<Lpmaster>> GetAllLpmasterAsync() => await _repository.GetAllLpmasterAsync();
        public async Task<Lpmaster> GetLpmasterAsync(int id) => await _repository.GetLpmasterAsync(id);
        public async Task UpdateAsync(Lpmaster subject) => await _repository.UpdateAsync(subject);
    }
}
