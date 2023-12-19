using Application.ApplicationServices.DTOs.PatientsDTOs;

namespace Application.Queries.PatientQueries.GetPatientById;

public sealed record PatientResponse(ReadPatientDTO ReadPatientDTO);
