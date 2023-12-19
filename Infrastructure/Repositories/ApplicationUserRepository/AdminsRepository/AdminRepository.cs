using Domain.Entites;
using Infrastructure.Database.EFCoreContext;
using Infrastructure.Repositories.BaseRepository;

namespace Infrastructure.Repositories.ApplicationUserRepository.AdminsRepository;

public class AdminRepository : GenericRepository<HospitalAdmin>, IAdminRepository
{
    public AdminRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
