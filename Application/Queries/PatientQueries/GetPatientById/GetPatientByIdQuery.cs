using Application.Abstractions.Messaging;

namespace Application.Queries.PatientQueries.GetPatientById;

public sealed record GetPatientByIdQuery(int Id) : IQuery<PatientResponse>;