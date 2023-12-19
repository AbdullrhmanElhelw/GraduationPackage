using Infrastructure.Database.EFCoreContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.BaseRepository;

public class GenericRepository<TModel>(ApplicationDbContext dbContext) : IGenericRepository<TModel> where TModel : class
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public async Task AddAsync(TModel entity) => await _dbContext.Set<TModel>().AddAsync(entity);


    public async Task DeleteAsync(TModel entity) => await Task.Run(() => _dbContext.Set<TModel>().Remove(entity));

    public async Task UpdateAsync(TModel entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
        await Task.Run(() => _dbContext.Set<TModel>().Update(entity));
    }
}
