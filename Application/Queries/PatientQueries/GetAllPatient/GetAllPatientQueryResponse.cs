using Application.ApplicationServices.DTOs.PatientsDTOs;

namespace Application.Queries.PatientQueries.GetAllPatient;

public record GetAllPatientQueryResponse(IEnumerable<ReadPatientDTO> Patients);