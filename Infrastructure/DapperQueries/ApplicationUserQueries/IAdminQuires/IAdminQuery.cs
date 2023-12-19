using Domain.Entites;
using Infrastructure.DapperQueries.BaseQueries;

namespace Infrastructure.DapperQueries.ApplicationUserQueries.IAdminQuires;

public interface IAdminQuery : IBaseQuery<ApplicationUser>
{
    Task<ApplicationUser> FindByEmail(string email);
}
