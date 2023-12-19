using Infrastructure.Repositories.PatientsRepository;

namespace Infrastructure.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IPatientRepository PatientRepository { get; }
    Task CommitAsync(CancellationToken cancellationToken);
}
