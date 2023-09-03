using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _table;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public async Task DeleteAllAsync()
        {
            var allEntities = await _table.ToListAsync();
            _table.RemoveRange(allEntities);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == default)
            {
                return false;
            }
            _table.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ExistsAsync(int? id)
        {
            var entity = await GetByIdAsync(id);
            return entity != default;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _table.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int? id)
        {
            if (id == default)
            {
                return default;
            }

            return await _table.FindAsync(id);
        }

        public async Task<T> InsertAsync(T entity)
        {
            await _table.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> IsEmpty()
        {
            var hasAnyData = await _table.AnyAsync();
            return !hasAnyData;
        }

        public async Task Update(T entity)
        {
            _table.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
