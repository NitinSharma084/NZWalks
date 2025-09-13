using NZWalks.API.Models.Domain;
using NZWalks.API.Data;
using Microsoft.EntityFrameworkCore;
namespace NZWalks.API.Repositories
{
    public class SQLWalkRepository : IWalksRepository
    {
        private readonly NZWalksDbContext DbContext;
        public SQLWalkRepository(NZWalksDbContext DbContext)
        {
            this.DbContext = DbContext;
        }

        public async Task<List<Walk>> GetAllAsync()
        {
            return await DbContext.Walks.ToListAsync();
        }

    }
}
