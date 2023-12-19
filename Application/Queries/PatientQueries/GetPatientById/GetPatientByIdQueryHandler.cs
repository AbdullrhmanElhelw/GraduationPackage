using Application.Abstractions.Messaging;
using Application.ApplicationServices.Mapping;
using Domain.Errors;
using Domain.Shared;
using Infrastructure.DapperQueries.PatientQueries;

namespace Application.Queries.PatientQueries.GetPatientById
{
    public sealed class GetPatientByIdQueryHandler : IQueryHandler<GetPatientByIdQuery, PatientResponse>
    {
        private readonly IPatientQuery _patientQuery;

        public GetPatientByIdQueryHandler(IPatientQuery patientQuery)
        {
            _patientQuery = patientQuery;
        }

        public async Task<Result<PatientResponse>> Handle(GetPatientByIdQuery request, CancellationToken cancellationToken)
        {
            var pateint = await _patientQuery.GetByIdAsync(request.Id);

            if (pateint is null)
                return Result.Failure<PatientResponse>(DomainErrors.PatientErrors.NotFound(request.Id));

            var patientResponse = PatientMappings.MappingToPatientResponse(pateint);

            return Result.Success(patientResponse);

        }
    }
}
