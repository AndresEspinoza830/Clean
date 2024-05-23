using Clean.Application.Interfaces;
using Clean.Infrastucture.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Clean.Infrastucture.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class 
    {
        private readonly ApplicationDbContext _context;
        private DbSet<T> _dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<List<T>> FindAll()
        {
          return await _dbSet.ToListAsync();
        }
    }
}
