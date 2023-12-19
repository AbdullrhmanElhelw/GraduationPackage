using Dapper;
using Infrastructure.Database.DapperContext;

namespace Infrastructure.DapperQueries.BaseQueries;

public class BaseQuery<TModel>(DapperDbContext context) : IBaseQuery<TModel> where TModel : class
{
    private readonly DapperDbContext _context = context;

    public async Task<IQueryable> GetAllAsync()
    {
        var query = $"SELECT * FROM {typeof(TModel).Name}";
        var result = await _context.Connection.QueryAsync<TModel>(query);
        return result.AsQueryable();
    }

    public async Task<TModel> GetByIdAsync(int id)
    {
        var query = $"SELECT * FROM {typeof(TModel).Name} WHERE Id = @Id";
        var result = await _context.Connection.QueryFirstOrDefaultAsync<TModel>(query, new { Id = id });
        return result!;
    }
}
