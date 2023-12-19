using Application.ApplicationServices.DTOs.PatientsDTOs;
using Application.Queries.PatientQueries.GetPatientById;
using Domain.Entites;

namespace Application.ApplicationServices.Mapping;

internal class PatientMappings
{
    public static Patient MappingToPatient(CreatePatientDTO createPatient)
    =>
         new()
         {
             FirstName = createPatient.FirstName,
             LastName = createPatient.LastName,
             Address = createPatient.Address,
             City = createPatient.City,
             SSN = createPatient.SSN
         };

    public static ReadPatientDTO MappingToReadPatientDTO(Patient patient)
    {
        return new ReadPatientDTO
        {
            Id = patient.Id,
            FirstName = patient.FirstName,
            LastName = patient.LastName,
            Address = patient.Address,
            City = patient.City,
            SSN = patient.SSN
        };
    }

    public static PatientResponse MappingToPatientResponse(Patient patient)
    {
        var patientresponse = MappingToReadPatientDTO(patient);
        return new PatientResponse(patientresponse);
    }


}
