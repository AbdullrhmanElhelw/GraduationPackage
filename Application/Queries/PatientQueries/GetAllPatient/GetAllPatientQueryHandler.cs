using Application.Abstractions.Messaging;
using Application.ApplicationServices.DTOs.PatientsDTOs;
using Application.ApplicationServices.Mapping;
using Domain.Entites;
using Domain.Shared;
using Infrastructure.DapperQueries.PatientQueries;

namespace Application.Queries.PatientQueries.GetAllPatient;

public sealed class GetAllPatientQueryHandler(IPatientQuery patientQuery)
    : IQueryHandler<GetAllPatientQuery, IEnumerable<ReadPatientDTO>>
{
    private readonly IPatientQuery _patientQuery = patientQuery;
    public async Task<Result<IEnumerable<ReadPatientDTO>>> Handle(GetAllPatientQuery request, CancellationToken cancellationToken)
    {
        var patients = await _patientQuery.GetAllAsync();
        if (patients == null)
            return Result.Failure<IEnumerable<ReadPatientDTO>>(new Error("1-2-NotFound", "NO Patients Found"));

        var patientCasting = patients.Cast<Patient>();
        var readPatientDTOs = MapToReadPatientDTO(patientCasting);

        return Result.Success(readPatientDTOs);
    }

    private static IEnumerable<ReadPatientDTO> MapToReadPatientDTO(IQueryable<Patient> patients)
    {
        var readPatientDTOs = new List<ReadPatientDTO>();
        foreach (var patient in patients)
        {
            var readPatientDTO = PatientMappings.MappingToReadPatientDTO(patient);
            readPatientDTOs.Add(readPatientDTO);
        }
        return readPatientDTOs.AsEnumerable();
    }

}
