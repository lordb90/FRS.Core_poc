using FRS.Core.Domain.Entities;
using FRS.Core.Domain.Interfaces;
using FRS.Core.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRS.Core.Infrastructure.Repositories
{
    public class LpmasterRepository : ILpmasterRepository
    {
        private readonly FrsEnterpriseContext _dbContext;

        public LpmasterRepository(FrsEnterpriseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Lpmaster subject)
        {
            // Over simplification the process but getting to gist 
            await _dbContext.AddAsync(subject);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Lpmaster subject)
        {
            _dbContext.Remove(subject);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Lpmaster>> GetAllLpmasterAsync()
        {
            return await _dbContext.Lpmasters.ToListAsync();
        }

        public async Task<Lpmaster> GetLpmasterAsync(int id)
        {
            var result = await _dbContext.Lpmasters.FirstOrDefaultAsync(x => x.Id == id);
            if (result == null)
            {
                throw new InvalidOperationException($"No Lpmaster found with Id {id}");
            }
            return result;
        }

        public async Task UpdateAsync(Lpmaster subject)
        {
            _dbContext.Update(subject);
            await _dbContext.SaveChangesAsync(true);
        }
    }
}
