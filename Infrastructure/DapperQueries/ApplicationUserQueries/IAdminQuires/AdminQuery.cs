using Dapper;
using Domain.Entites;
using Infrastructure.DapperQueries.BaseQueries;
using Infrastructure.Database.DapperContext;

namespace Infrastructure.DapperQueries.ApplicationUserQueries.IAdminQuires;

public class AdminQuery(DapperDbContext context) : BaseQuery<ApplicationUser>(context), IAdminQuery
{
    private readonly DapperDbContext _context = context;

    public Task<ApplicationUser> FindByEmail(string email)
    {
        var sql = $"SELECT * FROM {typeof(ApplicationUser).Name} WHERE Email = @Email";
        using var connection = _context.Connection;
        Console.WriteLine(typeof(ApplicationUser).Name);
        var result = connection.QueryFirstOrDefaultAsync<ApplicationUser>(sql, new { Email = email });
        return result;
    }
}
