namespace LeaveManagement.Web.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<bool> ExistsAsync(int? id);
        Task<T> InsertAsync(T entity);
        Task Update(T entity);
        Task<bool> DeleteAsync(int id);
        Task DeleteAllAsync();
        Task<bool> IsEmpty();
    }
}
