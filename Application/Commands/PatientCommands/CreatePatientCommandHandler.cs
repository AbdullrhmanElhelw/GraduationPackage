using Application.Abstractions.Messaging;
using Application.ApplicationServices.Mapping;
using Domain.Shared;
using Infrastructure.Repositories.PatientsRepository;
using Infrastructure.UnitOfWork;

namespace Application.Commands.PatientCommands;

public sealed class CreatePatientCommandHandler
        (IPatientRepository patientRepository, IUnitOfWork unitOfWork)
        : ICommandHandler<CreatePatientCommand>
{
    private readonly IPatientRepository _patientRepository = patientRepository;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<Result> Handle(CreatePatientCommand request, CancellationToken cancellationToken)
    {
        var patient = PatientMappings.MappingToPatient(request.CreatePatient);
        await _patientRepository.AddAsync(patient);
        await _unitOfWork.CommitAsync(cancellationToken);
        return Result.Success();
    }

}
