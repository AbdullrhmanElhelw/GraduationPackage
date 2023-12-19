using Domain.Entites;
using Infrastructure.Database.EFCoreContext;
using Infrastructure.Repositories.BaseRepository;

namespace Infrastructure.Repositories.PatientsRepository;

public class PatientRepository(ApplicationDbContext context)
    : GenericRepository<Patient>(context), IPatientRepository
{
    private readonly ApplicationDbContext _context = context;

}
