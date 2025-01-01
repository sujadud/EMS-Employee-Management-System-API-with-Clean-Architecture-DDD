namespace EmpAPI.Data.Interface
{
    public interface IGenericRepository<T> where T : IId
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<bool> AddAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> DeleteAllAsync(List<T> ids);
    }
}
