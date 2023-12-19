namespace Infrastructure.Repositories.BaseRepository;

public interface IGenericRepository<T> where T : class
{
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}
