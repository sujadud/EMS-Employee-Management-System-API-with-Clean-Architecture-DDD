using EmpAPI.Data.Interface;
using Microsoft.EntityFrameworkCore;

namespace EmpAPI.Data.Services
{
    public class EntityService<T> : IGenericRepository<T> where T : class, IId
    {
        private readonly EmpDbContext _context;
        private readonly DbSet<T> _dbSet;

        public EntityService(EmpDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                // Handle the exception as needed
                throw new Exception($"Error fetching all entities: {ex.Message}", ex);
            }
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            try
            {
                return await _dbSet.FindAsync(id);
            }
            catch (Exception ex)
            {
                // Handle the exception as needed
                throw new Exception($"Error fetching entity by ID: {ex.Message}", ex);
            }
        }

        public async Task<bool> AddAsync(T entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                // Handle the exception as needed
                throw new Exception($"Error adding entity: {ex.Message}", ex);
            }
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            try
            {
                _dbSet.Update(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                // Handle the exception as needed
                throw new Exception($"Error updating entity: {ex.Message}", ex);
            }
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                var entity = await _dbSet.FindAsync(id);
                if (entity == null) return false;

                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                // Handle the exception as needed
                throw new Exception($"Error deleting entity: {ex.Message}", ex);
            }
        }

        public async Task<bool> DeleteAllAsync(List<T> entities)
        {
            try
            {
                _dbSet.RemoveRange(entities);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                // Handle the exception as needed
                throw new Exception($"Error deleting entities: {ex.Message}", ex);
            }
        }
    }
}
