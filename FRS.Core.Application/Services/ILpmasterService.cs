using FRS.Core.Domain.Entities;

namespace FRS.Core.Application.Services
{
    public interface ILpmasterService
    {
        Task AddAsync(Lpmaster subject);
        Task DeleteAsync(Lpmaster subject);
        Task<List<Lpmaster>> GetAllLpmasterAsync();
        Task<Lpmaster> GetLpmasterAsync(int id);
        Task UpdateAsync(Lpmaster subject);
    }
}
