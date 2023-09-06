using FRS.Core.Domain.Entities;

namespace FRS.Core.Domain.Interfaces
{
    public interface ILpmasterRepository
    {
        Task<Lpmaster> GetLpmasterAsync(int id);
        Task<List<Lpmaster>> GetAllLpmasterAsync();
        Task AddAsync(Lpmaster subject);
        Task DeleteAsync(Lpmaster subject);
        Task UpdateAsync(Lpmaster subject);
    }
}
