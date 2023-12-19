using Domain.Entites;
using Infrastructure.Repositories.BaseRepository;

namespace Infrastructure.Repositories.PatientsRepository;

public interface IPatientRepository : IGenericRepository<Patient>
{

}
