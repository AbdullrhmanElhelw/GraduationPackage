namespace Infrastructure.DapperQueries.BaseQueries;

public interface IBaseQuery<T> where T : class
{
    Task<IQueryable> GetAllAsync();
    Task<T> GetByIdAsync(int id);
}
