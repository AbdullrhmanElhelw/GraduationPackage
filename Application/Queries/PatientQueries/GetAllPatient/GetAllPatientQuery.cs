using Application.Abstractions.Messaging;
using Application.ApplicationServices.DTOs.PatientsDTOs;

namespace Application.Queries.PatientQueries.GetAllPatient;

public record GetAllPatientQuery : IQuery<IEnumerable<ReadPatientDTO>>;

